using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieLand.Models;
using MovieLand.db;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.Text.RegularExpressions;
using Accord.Math;
using System.Data;
using Accord.MachineLearning.DecisionTrees;

namespace MovieLand.Controllers
{
    public class GameController : Controller
    {

        // creating context then passing it to controller
        private readonly ShopContext _context;

        public GameController(ShopContext context)
        {
            _context = context;
        }
         
        // results for search by price
        public List<Movie> search(string priceSearch, string yearSearch, string genreSearch, string recGamesIds =null)
        {
            // all games
            var movies = from m in _context.Movies select m;

            // this parameter is used as a string of game ids passed only from the recomendations view,
            // this is used to avoid calculating recommended games each time the user searches games in his recommendations view
            //if (recGamesIds != null)
            //{
            //    movies = _context.Movies.Where(movie => recGamesIds.Contains(movie.movieID));
            //}

            // search based on price
            if (yearSearch != null)
            {
                switch (yearSearch)
                {
                    case "Any":
                        break;
                    case "1990's and Earlier":
                        movies = movies.Where(movie => movie.year < 2000);
                        break;
                    case "2000's":
                        movies = movies.Where(movie => movie.year >= 2000 && movie.year < 2010);
                        break;
                    case "2010's":
                        movies = movies.Where(movie => movie.year >= 2010);
                        break;
                }

            }

            // search based on price
            if (priceSearch != null)
            {
                switch (priceSearch)
                {
                    case "Any":
                        break;
                    case "Under 40 NIS":
                        movies = movies.Where(movie => Convert.ToInt32((movie.price.Substring(0, movie.price.Length - 4))) < 40);
                        break;
                    case "Under 100 NIS":
                        movies = movies.Where(movie => Convert.ToInt32((movie.price.Substring(0, movie.price.Length - 4))) < 100);
                        break;
                    case "Under 200 NIS":
                        movies = movies.Where(movie => Convert.ToInt32((movie.price.Substring(0, movie.price.Length - 4))) < 200);
                        break;
                }

            }

            // search based on genre
            if (genreSearch != null && genreSearch != "Any")
            {
                movies = movies.Where(movie => movie.genre.Contains(genreSearch));
            }

            return movies.ToList();
        }
    
        // GET: Games
        public async Task<IActionResult> Index()
        {
            // query games 
            var games = from movie in _context.Movies select movie;

            // create list for price categories
            List<string> priceCategory = new List<string> { "Under 40 NIS", "Under 100 NIS", "Under 200 NIS" };
            ViewBag.priceCategory = priceCategory;

            // create list for year categories
            List<string> yearCategory = new List<string> { "1990's and Earlier", "2000's", "2010's" };
            ViewBag.yearCategory = yearCategory;

            // query genres
            var genres =  _context.Movies.Select(movie => movie.genre).Distinct().ToList();

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
            ViewBag.genres = singleGenres;
 
            return View(await games.ToListAsync());
        }

        // GET: Game/Details/
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(movie => movie.movieID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Games/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("movieID,imdbID,movieName,year,price,director,genre,trailerID")] Movie movie)
        {
            // linq query to check if a game id exists
            var movieExists =
               from m in _context.Movies
               where m.movieID == movie.movieID
               select m;

            if (!movieExists.Any())
            {
                if (ModelState.IsValid)
                {
                    float rating = imdbRating(movie.imdbID);
                    movie.rating = rating;

                    _context.Add(movie);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(movie);
            }
            else
            {
                ViewBag.Error3 = "Movie Already Exists";
                return View();
            }
            
        }


        // GET: Games/Delete
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.movieID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Games/Delete
        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.movieID == id);

            // delete all this specific game's orders (order is a weak entity and cannot exist without a valid game id)
            _context.Orders.RemoveRange(_context.Orders.Where(o => o.movieID == id));

            // delete the customer
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
  
            return RedirectToAction(nameof(Index));
        }

        // GET: Game/Edit
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Game/Edit 
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("movieID,imdbID,movieName,price,director,genre,trailerID")] Movie movie)
        {  
            if (id != movie.movieID)
            {
                return NotFound();
            }
         
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Movies.Any(m => m.movieID == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Game/Buy
        [Authorize]
        public async Task<IActionResult> Buy(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // you can only order games if you are authenticated, if not the it redirects to login page
            if (User.Identity.IsAuthenticated)
            {
                var movie = await _context.Movies.FindAsync(id);
                if (movie == null)
                {
                    return NotFound();
                }
                return View(movie);
            }
            return RedirectToAction("Login", "Account");
        }

        // POST: Games/Buy
        [Authorize]
        [HttpPost, ActionName("Buy")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buy(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                // linq query to check if a customer is registered
                var customerExists =
                   from customer in _context.Customers
                   where customer.Username == User.Identity.Name
                   select customer;

                if (customerExists.Any())
                {
                    if (ModelState.IsValid)
                    {
                        // create new order and add it to the db               
                        var order = new Order { CustomerUsername = User.Identity.Name, movieID = id, OrderDate = DateTime.Now };
                        _context.Orders.Add(order);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                   
                }
                // if the customer is not registered in the db, redirects to create customer page and requests to register as a customer before ordering
                else 
                {
                    ViewBag.Error = "please add customer data before ordering";
                    return RedirectToAction("CreateForUser", "Customer");
                }

            }

            return RedirectToAction(nameof(Index));
            
        }

        // this handles the request and response to and from the steam (massive online game store) databse by game id (it has to be the game id on the steam database)
        public static HttpWebResponse getImdbData(string id)
        {
            string url = "http://www.omdbapi.com/?i=" + id ;
            HttpWebRequest httpRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            httpRequest.Method = "GET";
            var response = (HttpWebResponse)httpRequest.GetResponse();

            return response;
        }

        // this parses the response from the steam database in order to get the games price (you get alot of other data as well)
        public static float imdbRating(string id)
        {
            var result = getImdbData(id);
            System.IO.StreamReader sr = new System.IO.StreamReader(result.GetResponseStream());
            string line = "";
            // the regex to get the price from the data
            Regex reg = new Regex(@"imdbRating.:.(\d.\d)");

            while ((line = sr.ReadLine()) != null)
            {
                Match match = reg.Match(line);
                if (match.Success)
                {
                    return (float.Parse(match.Groups[1].Value));
                }
            }

            // default price (its 50.00 and later the cents are deleted)
            return (0);        
        }   
    }
}

