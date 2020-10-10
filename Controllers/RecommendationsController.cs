using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Accord.Math;
using System.Data;
using Accord.Statistics.Filters;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.DecisionTrees;

namespace MovieLand.Controllers
{
    using MovieLand.db;
    using MovieLand.Models;

    public class RecommendationsController : Controller
    {
        private readonly ShopContext _context;

        public RecommendationsController(ShopContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult RecommendationsByMovies()
        {
            string id = User.Identity.Name;
            var Movies = from movie in _context.Movies
                         select movie;

            List<string> priceCategory = new List<string> { "Under 40 NIS", "Under 100 NIS", "Under 200 NIS" };
            ViewBag.priceCategory = priceCategory;

            var genres = _context.Movies.Select(movie => movie.Genre).Distinct().ToList();

            HashSet<string> singleGenres = getSingleGenres();
            ViewBag.genres = singleGenres;

            List<string> yearCategory = new List<string> { "1990's and Earlier", "2000's", "2010's" };
            ViewBag.yearCategory = yearCategory;

            List<string> ratings = new List<string> { "7+", "8+", "9+" };
            ViewBag.ratings = ratings;

            var directors = _context.Movies.Select(movie => movie.Director).Distinct().ToList();
            ViewBag.directors = directors;

            var results = getRecommendationsByContent(id);
            var recommendedMovies = _context.Movies.Where(movie => results.Contains(movie.MovieID)).ToList();

            return View(recommendedMovies);
        }

        [Authorize]
        public IActionResult RecommendationsByUsers()
        {
            string id = User.Identity.Name;
            var Movies = from movie in _context.Movies
                         select movie;

            List<string> priceCategory = new List<string> { "Under 40 NIS", "Under 100 NIS", "Under 200 NIS" };
            ViewBag.priceCategory = priceCategory;

            var genres = _context.Movies.Select(movie => movie.Genre).Distinct().ToList();

            HashSet<string> singleGenres = getSingleGenres();
            ViewBag.genres = singleGenres;

            List<string> yearCategory = new List<string> { "1990's and Earlier", "2000's", "2010's" };
            ViewBag.yearCategory = yearCategory;

            List<string> ratings = new List<string> { "7+", "8+", "9+" };
            ViewBag.ratings = ratings;

            var directors = _context.Movies.Select(movie => movie.Director).Distinct().ToList();
            ViewBag.directors = directors;

            var results = getRecommendationsByUsers(id);
            List<Movie> recommendedMovies = new List<Movie>();
       
            var orders = _context.Orders.Where(order => order.CustomerUsername == id).Include(order => order.OrderedMovie);
            var orderedMovies =
                from oreder in orders
                select oreder.OrderedMovie;
            var orderedMoviesList = orderedMovies.ToList();

            if (results != "Unfortunatly No Matches Were Found")
            {
                recommendedMovies = _context.Movies.Where(movie => (movie.Genre.Contains(results)) && (!orderedMoviesList.Contains(movie))).ToList();
            }
            
            return View(recommendedMovies);
        }

        [Authorize]
        public HashSet<int> getRecommendationsByContent(string id)
        {        
            var orders = _context.Orders.Where(order => order.CustomerUsername == id).Include(order => order.OrderedMovie);
            var orderedMovies =
                from o in orders
                select o.OrderedMovie;
            var orderedMoviesList = orderedMovies.ToList();
            var allOtherMoviesList = _context.Movies.Where(movie => !orderedMoviesList.Contains(movie)).ToList();

            var genreArray = getSingleGenres().ToArray();
            genreArray.Sort();

            HashSet<int> MovieRecommendations = new HashSet<int>();
            int[] MovieIds = new int[allOtherMoviesList.Count];    
            double[][] matrix = new double[allOtherMoviesList.Count][];
            int counter = 0;
            foreach (Movie Movie in allOtherMoviesList)
            {
                MovieIds[counter] = Movie.MovieID;
                matrix[counter] = toBinaryArray(Movie.Genre);
                counter++;
            }
         
            Accord.Math.Distances.Manhattan mh = new Accord.Math.Distances.Manhattan();
            double dist = 10; 
            foreach (Movie orderedMovie in orderedMoviesList)
            {
                for (int i = 0; i < (matrix.Rows()); i++)
                {
                    dist = mh.Distance(toBinaryArray(orderedMovie.Genre), matrix[i]);
                    if (dist < 3)
                    {                       
                        MovieRecommendations.Add(MovieIds[i]);
                    }
                }
            }
            return MovieRecommendations;
        }

        public HashSet<string> getSingleGenres()
        {
            var genres = _context.Movies.Select(g => g.Genre).Distinct().ToList();
            HashSet<string> singleGenres = new HashSet<string>();
            foreach (string genre in genres)
            {
                var temp = genre.Split(",");
                foreach (string singleGenre in temp)
                {
                    singleGenres.Add(singleGenre);
                }
            }
            return singleGenres;
        }

        public double[] toBinaryArray(string genres)
        {
            var allGenreArray = getSingleGenres().ToArray();
            allGenreArray.Sort();
            double[] binaryArray = new double[allGenreArray.Length];
            int counter = 0;

            foreach (string allGenre in allGenreArray)
            {
                if (genres.Contains(allGenre))
                {
                    binaryArray[counter] = 1;
                }
                else
                {
                    binaryArray[counter] = 0;
                }
                counter++;

            }

            return binaryArray;
        }

        public string getRecommendationsByUsers(string id = "user4")
        {
            DataTable data = new DataTable("dataTable");

            PopulateHead(data);          
            PopulateTable(data, id);

            Codification codification = new Codification(data);
            DataTable codifiedData = codification.Apply(data);

            int[][] input = codifiedData.ToJagged<int>("Age","Gender");

            int[] predictions = codifiedData.ToArray<int>("Best Genre");

            ID3Learning decisionTreeLearningAlgorithm = new ID3Learning { };

            try
            {
                var customer = _context.Customers.Where(c => c.Username == id).FirstOrDefault();
                int[] query;
                if (customer.Age <= 12)
                {
                    query = codification.Transform(new[,] { { "Age", "0-12" }, { "Gender", customer.Gender.ToString() } });
                }
                else if (12 < customer.Age && customer.Age <= 25)
                {
                    query = codification.Transform(new[,] { { "Age", "13-25" }, { "Gender", customer.Gender.ToString() } });
                }
                else if (25 < customer.Age && customer.Age < 40)
                {
                    query = codification.Transform(new[,] { { "Age", "26-39" }, { "Gender", customer.Gender.ToString() } });
                }
                else
                {
                    query = codification.Transform(new[,] { { "Age", "40+" }, { "Gender", customer.Gender.ToString() } });
                }

                DecisionTree decisionTree = decisionTreeLearningAlgorithm.Learn(input, predictions);                
                int result = decisionTree.Decide(query);
                string diagnosis = codification.Revert("Best Genre", result);
                return diagnosis;
            }
            catch (Exception)
            {
                return "Unfortunatly No Matches Were Found";
                throw;
            }
            
            
        }

        public void PopulateHead(DataTable data)
        {

            data.Columns.Add(new DataColumn("Age", typeof(string)));
            data.Columns.Add(new DataColumn("Gender", typeof(string)));
            data.Columns.Add(new DataColumn("Best Genre", typeof(string))); 

        }

        public void PopulateTable(DataTable data, string id)
        {
            var customers = _context.Customers.ToList();
            var singleGenres = getSingleGenres();
            var singleGenresArray = singleGenres.ToArray();
            singleGenresArray.Sort();

            foreach (Customer customer in customers)
            {         
                var orders = _context.Orders.Where(o => o.CustomerUsername == customer.Username).Include(o => o.OrderedMovie);
                if (!orders.Any())
                {
                    continue;
                }
                var orderedMovies =
                from o in orders
                select o.OrderedMovie;
                var orderedMoviesList = orderedMovies.ToList();

                double[] sumGenreVector = new double[singleGenresArray.Length];
                foreach (Movie Movie in orderedMoviesList)
                {
                    sumGenreVector = sumGenreVector.Zip(toBinaryArray(Movie.Genre), (x, y) => x + y).ToArray();
                }
                int counter = 0;
                double topGenre = -1;
                int topGenreIndex = -1;               
                foreach (double i in sumGenreVector)
                {
                    if (i>topGenre)
                    {                      
                        topGenre = i;
                        topGenreIndex = counter;
                    }
                    counter++;
                }

                var customerInTable = data.NewRow();
                customerInTable["Gender"] = customer.Gender.ToString();               
                if (customer.Age<=12)
                {
                    customerInTable["Age"] = "0-12";
                }
                else if (12<customer.Age && customer.Age<=25)
                {
                    customerInTable["Age"] = "13-25";
                }
                else if (25 < customer.Age && customer.Age < 40)
                {
                    customerInTable["Age"] = "26-39";
                }
                else 
                {
                    customerInTable["Age"] = "40+";
                }
                customerInTable["Best Genre"] = singleGenresArray[topGenreIndex];
                data.Rows.Add(customerInTable);

            }
            
            
        }
    }
}



