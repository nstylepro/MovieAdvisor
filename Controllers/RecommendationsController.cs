using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieLand.Models;
using MovieLand.db;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.Text.RegularExpressions;
using Accord.MachineLearning;
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

        // creating context then passing it to controller
        private readonly ShopContext _context;

        public RecommendationsController(ShopContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult RecommendationsByGames()
        {
            string id = User.Identity.Name;
            // query games 
            var games = from g in _context.Movies
                        select g;

            // create list for price categories
            List<string> priceCategory = new List<string> { "Under 40 NIS", "Under 100 NIS", "Under 200 NIS" };
            ViewBag.priceCategory = priceCategory;

            // query genres
            var genres = _context.Movies.Select(g => g.Genre).Distinct().ToList();

            // get single genres for the search options
            HashSet<string> singleGenres = getSingleGenres();
            ViewBag.genres = singleGenres;

            // query companies
            var companies = _context.Movies.Select(g => g.Director).Distinct().ToList();
            ViewBag.companies = companies;

            var results = getRecommendationsByContent(id);
            var recommendedGames = _context.Movies.Where(g => results.Contains(g.MovieID)).ToList();

            return View(recommendedGames);
        }

        // user based recommendations (recommends games by other users with similar data)
        [Authorize]
        public IActionResult RecommendationsByUsers()
        {
            string id = User.Identity.Name;
            // query games 
            var games = from g in _context.Movies
                        select g;

            // create list for price categories
            List<string> priceCategory = new List<string> { "Under 40 NIS", "Under 100 NIS", "Under 200 NIS" };
            ViewBag.priceCategory = priceCategory;

            // query genres
            var genres = _context.Movies.Select(g => g.Genre).Distinct().ToList();

            // get single genres for the search options
            HashSet<string> singleGenres = getSingleGenres();
            ViewBag.genres = singleGenres;

            // query companies
            var companies = _context.Movies.Select(g => g.Director).Distinct().ToList();
            ViewBag.companies = companies;

            // get predicted top genre for current user
            var results = getRecommendationsByUsers(id);
            // initializing an empty movie list
            List<Movie> recommendedGames = new List<Movie>();
            
            //get the user's orders  ( so i dont recommend him games he already has)         
            var orders = _context.Orders.Where(o => o.CustomerUsername == id).Include(o => o.OrderedMovie);
            var orderedGames =
                from o in orders
                select o.OrderedMovie;
            var orderedGamesList = orderedGames.ToList();

            if (results != "Unfortunatly No Matches Were Found")
            {
                // get all games from that genre
                recommendedGames = _context.Movies.Where(g => (g.Genre.Contains(results)) && (!orderedGamesList.Contains(g))).ToList();
            }
            
            return View(recommendedGames);
        }

        // content based recomendations - Item-Based Collaborative Filtering
        // this uses distance algorithem to recommend games to a user by a similarity score of his ordered games to other games in the store
        [Authorize]
        public HashSet<int> getRecommendationsByContent(string id)
        {

            //get the customer's orders           
            var orders = _context.Orders.Where(o => o.CustomerUsername == id).Include(o => o.OrderedMovie);
            var orderedGames =
                from o in orders
                select o.OrderedMovie;
            var orderedGamesList = orderedGames.ToList();
            // all games teh customer didnt order
            var allOtherGamesList = _context.Movies.Where(g => !orderedGamesList.Contains(g)).ToList();

            // my function that reutrns a list of all single genres ("FPS,Loot,RPG" => ["FPS","Loot","Rpg"])
            var genreArray = getSingleGenres().ToArray();
            genreArray.Sort();

            HashSet<int> GameRecommendations = new HashSet<int>();
            // this is in order to know the movie id later (the indexes are the same)
            int[] gameIds = new int[allOtherGamesList.Count];
            // this is a jagged array of binary vectors, each vector is the geners of a movie coded into 1 if the movie is in that genre and 0 if its not
            // this contains the vectors of all games the curretn user didnt order
            double[][] matrix = new double[allOtherGamesList.Count][];
            // matrix[0] = genreArray;
            int counter = 0;
            // create binary vector of genres for each movie the customer didnt order for later comparsion
            foreach (Movie game in allOtherGamesList)
            {
                // to know the movie id later
                gameIds[counter] = game.MovieID;
                // my functions that codes games genres into 1s and 0s array
                matrix[counter] = toBinaryArray(game.Genre);
                counter++;
            }


            // use distance function to calcualte distance between 2 games
            // i wanted to use similarity which was supposed to be more accurate but it didnt work as intended so i switched to distance
            Accord.Math.Distances.Manhattan mh = new Accord.Math.Distances.Manhattan();
            double dist = 10; // the value doesnt matter
            foreach (Movie orderedGame in orderedGamesList)
            {
                for (int i = 0; i < (matrix.Rows()); i++)
                {
                    // calculate the distance between each movie the customer ordered and the rest of the games 
                    dist = mh.Distance(toBinaryArray(orderedGame.Genre), matrix[i]);
                    // determines how strict the recommendation will be. the higher the number the more recommendations we get (but less accurate)
                    if (dist < 3)
                    {
                        // if the movie he didnt order is close enough to the ones he did order then its gameid is added to the hashset that is later returned
                        GameRecommendations.Add(gameIds[i]);
                    }
                }
            }
            return GameRecommendations;
        }



        // return a set of the movie genres
        public HashSet<string> getSingleGenres()
        {
            // query genres
            var genres = _context.Movies.Select(g => g.Genre).Distinct().ToList();

            // get single genres for the search options
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

        // create binary array from genres
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

        // this uses decision tree algorithem that learns other customer data (age and gender but more can be added easily) and their favourite genre, 
        // then it uses the created prediction model on the current user's data and predicts his favourite genre (by favourite genres of other similiar users)
        public string getRecommendationsByUsers(string id = "user4")
        {
            // Step 1: data table
            DataTable data = new DataTable("dataTable");


            // Step 2: populate table, last column is prediction column 
            // this are my functions to populate the table from existing customers and their orders
            PopulateHead(data);          
            PopulateTable(data, id);

            // Step 3: convert to numerical representaion
            Codification codification = new Codification(data);
            DataTable codifiedData = codification.Apply(data);

            // all columns except last one which we want tp predict
            int[][] input = codifiedData.ToJagged<int>("Age","Gender");

            int[] predictions = codifiedData.ToArray<int>("Best Genre");

            // Step 4: decision tree
            ID3Learning decisionTreeLearningAlgorithm = new ID3Learning { };

            

            
            // this will only work if there is enough data in the db.
            try
            {
                // Step 5: get the customer, then prduce a query from current customer to feed to the decision tree
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

                // Step 6: use decision tree on current user data
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
            data.Columns.Add(new DataColumn("Best Genre", typeof(string))); // prediction column

        }

        public void PopulateTable(DataTable data, string id)
        {
            // get all customers
            var customers = _context.Customers.ToList();
            // get genres then sort them
            var singleGenres = getSingleGenres();
            var singleGenresArray = singleGenres.ToArray();
            singleGenresArray.Sort();

            foreach (Customer customer in customers)
            {
                //get a customer's orders           
                var orders = _context.Orders.Where(o => o.CustomerUsername == customer.Username).Include(o => o.OrderedMovie);
                if (!orders.Any())
                {
                    continue;
                }
                // ordered games
                var orderedGames =
                from o in orders
                select o.OrderedMovie;
                var orderedGamesList = orderedGames.ToList();
                
                // sum this specific users ordered movie genres into a vector then sort it and detrmine the top genre by this user
                double[] sumGenreVector = new double[singleGenresArray.Length];
                foreach (Movie game in orderedGamesList)
                {
                    sumGenreVector = sumGenreVector.Zip(toBinaryArray(game.Genre), (x, y) => x + y).ToArray();
                }
                // get index of max (i wrote this and didnt use .max because originaly i tried doing somthing else)
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
                // create the rows (each row represents a customer)
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




// some snippets of ealier stages and failed attempts
/*

DataTable data = new DataTable("rec");


PopulateGenres(data); 


PopulateGames(data);


Codification codification = new Codification(data);
DataTable codifiedData = codification.Apply(data);

var genreArray = getSingleGenres().ToArray();
 
int[][] input = codifiedData.ToJagged<int>(genreArray);

int[] predictions = codifiedData.ToArray<int>("Movie ID");


ID3Learning decisionTreeLearningAlgorithm = new ID3Learning { };

DecisionTree decisionTree = decisionTreeLearningAlgorithm.Learn(input, predictions);




int[] query = codification.Transform(new[,]{ {"Cards","no" },
                                       { "FPS","yes" },
                                       { "Action" ,"no"},
                                       { "RPG","yes" },
                                       { "Strategy","yes" },
                                       { "Hard" ,"no"},
                                       { "MOBA" ,"no"},
                                       { "Adventure" ,"no"} });

int result = decisionTree.Decide(query);
string gameid = codification.Revert("Movie ID", result);

return gameid; */




/* get the customer's orders           
var orders = _context.Orders.Where(o => o.CustomerUsername == id).Include(o => o.OrderedMovie);
var orderedGames =
    from o in orders               
    select o.OrderedMovie;
var orderedGamesList = orderedGames.ToList();
var allOtherGames = _context.Movies.Where(g => !orderedGamesList.Contains(g));



// create matrix head (genre titles of all genres)
object[][] matrix = new object[3][];
matrix[0] = genreArray;

*/


/*
 * // create a data table head that will be used as input for the decision tree algorithem
        public void PopulateGenres(DataTable data)
        {

            var singleGenres = getSingleGenres();
            foreach (string genre in singleGenres)
            {
                data.Columns.Add(new DataColumn(genre, typeof(string)));
            }
            data.Columns.Add(new DataColumn("Movie ID", typeof(string)));

        }

        public void PopulateGames(DataTable data)
        {
            var games = _context.Movies.ToList();
            var singleGenres = getSingleGenres();

            // loop through all the games and genres to create a table to give the decision tree algorithem (row for each movie, columns are genres)
            foreach (Movie movie in games)
            {
                var gameInTable = data.NewRow();
                foreach (string genre in singleGenres)
                {
                    if (movie.Genre.Contains(genre))
                    {
                        gameInTable[genre] = "yes";
                    }
                    else
                    {
                        gameInTable[genre] = "no";
                    }
                }
                gameInTable["Movie ID"] = movie.MovieID.ToString();
                data.Rows.Add(gameInTable);
            }         
        }


    */
