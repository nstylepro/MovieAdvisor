﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.Text.RegularExpressions;
using Accord.Math;

namespace MovieLand.Controllers
{
    using MovieLand.db;
    using MovieLand.Models;

    public class MovieController : Controller
    {

        // creating context then passing it to controller
        private readonly ShopContext _context;

        public MovieController(ShopContext context)
        {
            _context = context;
        }
         
        // results for search by price
        public List<Movie> search(string priceSearch, string genreSearch, string companySearch, string recMoviesIds =null)
        {
            // all Movies
            var Movies = from g in _context.Movies
                        select g;
            // this parameter is used as a string of movie ids passed only from the recomendations view,
            // this is used to avoid calculating recommended Movies each time the user searches Movies in his recommendations view
            if (recMoviesIds != null)
            {
                Movies = _context.Movies.Where(g => recMoviesIds.Contains(g.MovieID.ToString()));
            }

            // search based on price
            if (priceSearch != null)
            {
                switch (priceSearch)
                {
                    case "Any":
                        break;
                    case "Under 40 NIS":
                        Movies = Movies.Where(g => Convert.ToInt32((g.Price.Substring(0, g.Price.Length - 4))) < 40);
                        break;
                    case "Under 100 NIS":
                        Movies = Movies.Where(g => Convert.ToInt32((g.Price.Substring(0, g.Price.Length - 4))) < 100);
                        break;
                    case "Under 200 NIS":
                        Movies = Movies.Where(g => Convert.ToInt32((g.Price.Substring(0, g.Price.Length - 4))) < 200);
                        break;
                }

            }

            // search based on genre
            if (genreSearch != null && genreSearch != "Any")
            {
                Movies = Movies.Where(g => g.Genre.Contains(genreSearch));
            }


            // search based on company
            if (companySearch != null && companySearch != "Any")
            {
                Movies = Movies.Where(g => g.Director == companySearch);
            }


            return Movies.ToList();
        }

        
        // GET: Movies
        public async Task<IActionResult> Index()
        {
            //ViewData["CurrentFilter"] = priceSearch;

            // query Movies 
            var Movies = from g in _context.Movies
                           select g;

            // create list for price categories
            List<string> priceCategory = new List<string> { "Under 40 NIS", "Under 100 NIS", "Under 200 NIS" };
            ViewBag.priceCategory = priceCategory;

            // query genres
            var genres =  _context.Movies.Select(g => g.Genre).Distinct().ToList();

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

            // query companies
            var companies = _context.Movies.Select(g => g.Director).Distinct().ToList();
            ViewBag.companies = companies;
 
            return View(await Movies.ToListAsync());
        }

        // GET: Movie/Details/
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Movie = await _context.Movies
                .FirstOrDefaultAsync(g => g.MovieID == id);
            if (Movie == null)
            {
                return NotFound();
            }

            return View(Movie);
        }

        // GET: Movies/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("MovieID,ImdbID,MovieName,Year,Price,Director,Genre,TrailerID")] Movie movie)
        {
            // linq query to check if a Movie id exists
            var movieExists =
                from m in _context.Movies
                where m.MovieID == movie.MovieID
                select m;

            if (!movieExists.Any())
            {
                if (ModelState.IsValid)
                {
                    float rating = imdbRating(movie.ImdbID);
                    movie.Rating = rating;

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


        // GET: Movies/Delete
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Movie = await _context.Movies
                .FirstOrDefaultAsync(g => g.MovieID == id);
            if (Movie == null)
            {
                return NotFound();
            }

            return View(Movie);
        }

        // POST: Movies/Delete
        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {


            var Movie = await _context.Movies.FirstOrDefaultAsync(g => g.MovieID == id);

            // delete all this specific movie's orders (order is a weak entity and cannot exist without a valid movie id)
            _context.Orders.RemoveRange(_context.Orders.Where(o => o.MovieID == id));
            // _context.SaveChangesAsync();

            // delete the customer
            _context.Movies.Remove(Movie);
            await _context.SaveChangesAsync();

            
            return RedirectToAction(nameof(Index));
        }

        // GET: Movie/Edit
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Movie = await _context.Movies.FindAsync(id);
            if (Movie == null)
            {
                return NotFound();
            }
            return View(Movie);
        }

        // POST: Movie/Edit 
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieID,MovieName,Price,Director,Genre,TrailerID")] Movie movie)
        {

            
            if (id != movie.MovieID)
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
                    if (!MovieExists(movie.MovieID))
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
        private bool MovieExists(int id)
        {
            return _context.Movies.Any(g => g.MovieID == id);
        }


        // GET: Movie/Buy
        [Authorize]
        public async Task<IActionResult> Buy(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // you can only order Movies if you are authenticated, if not the it redirects to login page
            if (User.Identity.IsAuthenticated)
            {
                var Movie = await _context.Movies.FindAsync(id);
                if (Movie == null)
                {
                    return NotFound();
                }
                return View(Movie);
            }

            return RedirectToAction("Login", "Account");


        }

        // POST: Movies/Buy
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
                        var order = new Order { CustomerUsername = User.Identity.Name, MovieID = id, OrderDate = DateTime.Now };
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

        // this handles the request and response to and from the imdb (massive online Movie store) databse by Movie id (it has to be the Movie id on the imdb database)
        public static HttpWebResponse getImdbData(string id)
        {
            string apikey = "e029e17a";
            string url = "http://www.omdbapi.com/?i=" + id + "&apikey=" + apikey;
            HttpWebRequest httpRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            httpRequest.Method = "GET";
            var response = (HttpWebResponse)httpRequest.GetResponse();

            return response;
        }

        // this parses the response from the imdb database in order to get the Movies price (you get alot of other data as well)
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

