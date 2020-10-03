using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieLand.Models;
using MovieLand.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieLand.Controllers
{
    using MovieLand.db;
    using MovieLand.Models;

    public class OrderController : Controller
    {
        // creating context then passing it to controller
        private readonly ShopContext _context;

        public OrderController(ShopContext context)
        {
            _context = context;
        }


        // GET: Orders
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index(string customerSearch, string gameSearch, string priceSearch, DateTime? edate, DateTime? ldate)
        {
            var orders =  _context.Orders
                .Include(o => o.OrderedMovie)
                .Include(o => o.Buyer)
                .Select(o => o);

            // so data wont reset when form is submitted
            ViewData["CurrentFilter"] = customerSearch;
            ViewData["CurrentEdate"] = edate?.ToString("yyyy-MM-dd hh:mm:ss");
            ViewData["CurrentLdate"] = ldate?.ToString("yyyy-MM-dd hh:mm:ss");

            // query movie names
            var games = _context.Movies.Select(g => g.MovieName).Distinct().ToList();
            ViewBag.games = games;

            // create list for price categories
            List<string> priceCategory = new List<string> { "Under 40 NIS", "Under 100 NIS", "Under 200 NIS" };
            ViewBag.priceCategory = priceCategory;

            // search based on price
            if (priceSearch != null)
            {
                switch (priceSearch)
                {
                    case "Any":
                        break;
                    case "Under 40 NIS":
                        orders = orders.Where(o => Convert.ToInt32((o.OrderedMovie.Price.Substring(0, o.OrderedMovie.Price.Length - 4))) < 40);
                        break;
                    case "Under 100 NIS":
                        orders = orders.Where(o => Convert.ToInt32((o.OrderedMovie.Price.Substring(0, o.OrderedMovie.Price.Length - 4))) < 100);
                        break;
                    case "Under 200 NIS":
                        orders = orders.Where(o => Convert.ToInt32((o.OrderedMovie.Price.Substring(0, o.OrderedMovie.Price.Length - 4))) < 200);
                        break;
                }

            }

            // search based on early date
            if (edate!=null)
            {
                orders = orders.Where(o => o.OrderDate > edate);
            }
            // search based on late date
            if (ldate!=null)
            {
                orders = orders.Where(o => o.OrderDate < ldate);
            }

            // search based on customer id
            if (customerSearch != null)
            {
                orders = orders.Where(o => o.CustomerUsername == customerSearch);
            }

            // search based on movie name
            if (gameSearch != null)
            {
                orders = orders.Where(o => o.OrderedMovie.MovieName == gameSearch);
            }

            return View(await orders.ToListAsync());
        }

        // GET: Order/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {                   
            return View();
        }

        // POST: Order/Create
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,CustomerUsername,MovieID,OrderDate")] Order order)
        {
            // linq query to check if a customer is registered
            var customerExists =
               from customer in _context.Customers
               where customer.Username == order.CustomerUsername
               select customer;

            // linq query to check if a movie id exists
            var gameExists =
               from game in _context.Movies
               where game.MovieID == order.GameID
               select game;


            // if the customer is registered in the db then they can order
            if (customerExists.Any() & gameExists.Any())
            {
                if (ModelState.IsValid)
                {
                    _context.Add(order);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(order);
            }

            // if the customer is not registered in the db, redirects to create customer page and requests to register as a customer before ordering
            else if (!customerExists.Any())
            {
                TempData["error"] = "please add customer data before ordering";
                return RedirectToAction("Create", "Customer");
            }

            // if the movie doesnt exist
            else
            {
                ViewBag.Error2 = "wrong movie id";
                return View();
            }
        }

        // GET: Order/Delete
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.OrderedMovie)
                .Include(o => o.Buyer)
                .FirstOrDefaultAsync(o => o.OrderID == id);

            // to prevent attempts to delete orders that are not your own, unless you are an admin
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != order.CustomerUsername))
            {
                return NotFound();
            }

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Order/Delete
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            
            var order = await _context.Orders.FindAsync(id);

            // to prevent attempts to delete orders that are not your own, unless you are an admin
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != order.CustomerUsername))
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            // return to appropriate page for admin and for regular users accordingly
            if (User.IsInRole("Administrator"))
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("DetailsForUser", "Customer");
        }


        // GET: Order/Edit
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Order/Edit 
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,CustomerUsername,MovieID,OrderDate")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            // linq query to check if a movie id exists
            var gameExists =
               from game in _context.Movies
               where game.MovieID == order.GameID
               select game;

            if (gameExists.Any())
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(order);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!OrderExists(order.OrderID))
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
                return View(order);
            }
            // if the movie doesnt exist
            else
            {
                ViewBag.Error2 = "wrong movie id";
                return View();
            }
        }
        private bool OrderExists(int id)
        {
            return _context.Orders.Any(o => o.OrderID == id);
        }

        public class GroupedCount
        {
            public string name;
            public int count;
        }

        // GET: Orders/Statistics
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Statistics(string groupChoice, string joinChoice)
        {

            // so data wont reset when form is submitted
            ViewData["CurrentFilterGroup"] = groupChoice;
            ViewData["CurrentFilterJoin"] = joinChoice;
           


            // create list for join categories
            List<string> groupOption = new List<string> { "Movie", "Customer" };
            // create list for join categories
            List<string> joinOption = new List<string> { "Movies", "Customers"};
            List<GroupedCount> empty = new List<GroupedCount>();
            ViewBag.group = groupOption;
            ViewBag.join = joinOption;
            
            
            return View(empty);
        }

        [Authorize(Roles = "Administrator")]
        public List<GroupedCount> groupResult(string group)
        {
            
                                  
            // group queries and final result 
            List<GroupedCount> result = new List<GroupedCount>();
            var groupedByGame = from o in _context.Orders
                                group o by o.OrderedMovie.MovieName into g
                                select new GroupedCount { name = g.Key, count = g.Count() };
            var groupedByCustomer = from o in _context.Orders
                                    group o by o.CustomerUsername into g
                                    select new GroupedCount { name = g.Key, count = g.Count() };
            // group
            if (group != null)
            {
                switch (group)
                {
                    case "Movie":
                        result = groupedByGame.OrderByDescending(x => x.count).ToList();
                        break;
                    case "Customer":
                        result = groupedByCustomer.OrderByDescending(x => x.count).ToList();
                        break;
                }

            }
            return result;
        }

        public class joinContent
        {
            public int orderID;
            public string customerUsername;
            public int gameID;
            public DateTime orderDate;
            public string country;
            public string gameName;
            public string company;
            public string city;
            public string street;
        }

        [Authorize(Roles = "Administrator")]
        public List<joinContent> joinResult(string join)
        {


            // join queries and final result 
            List<joinContent> joinResult = new List<joinContent>();
                      

            var innerJoinCustomer = from o in _context.Orders
                                    join c in _context.Customers on o.CustomerUsername equals c.Username
                                    select new joinContent { orderID = o.OrderID, customerUsername = o.CustomerUsername, orderDate = o.OrderDate, country = c.Country, city = c.City, street = c.Street, };
            var innerJoinGame = from o in _context.Orders
                                join g in _context.Movies on o.GameID equals g.MovieID
                                select new joinContent { orderID = o.OrderID, gameID = o.GameID, orderDate = o.OrderDate, gameName = g.MovieName, company = g.Director };

            // join
            if (join != null)
            {
                switch (join)
                {
                    case "Movies":
                        joinResult = innerJoinGame.ToList();
                        break;
                    case "Customers":
                        joinResult = innerJoinCustomer.ToList();
                        break;
                }

            }
            return joinResult;
        }


        // GET: Orders/Graphs
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Graphs(string group)
        {

            // so data wont reset when form is submitted
            //ViewData["CurrentFilterGroup"] = groupChoice;
            

            // create list for group categories
            List<string> groupOption = new List<string> { "Movie", "Customer" };
            
            
            ViewBag.group = groupOption;
            


            return View();
        }

        public JsonResult jsonGraph(string group)
        {
            // group queries and final result 
            //List<groupedCount> result = new List<groupedCount>();

            var groupedByGame = from o in _context.Orders
                                group o by o.OrderedMovie.MovieName into g
                                select new { name = g.Key, count = g.Count() };
            var groupedByCustomer = from o in _context.Orders
                                    group o by o.CustomerUsername into g
                                    select new { name = g.Key, count = g.Count() };
            // initialize
           
            var result = groupedByCustomer;

            // group
            if (group != null)
            {
                switch (group)
                {
                    case "Movie":
                    result = groupedByGame; 
                    break;
                    case "Customer":
                    result = groupedByCustomer; 
                    break;
                }

            }
            return Json(result);
        }
    }
}
   
