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
using GoogleMaps.LocationServices;

namespace MovieLand.Controllers
{
    using MovieLand.db;
    using MovieLand.Models;

    public class CustomerController : Controller
    {


        private readonly ShopContext _context;

        public CustomerController(ShopContext context)
        {
            _context = context;
        }


        // GET: Customers
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index(string countrySearch)
        {
            var customers = _context.Customers
                .Select(c => c);

            // query countries
            var countries = _context.Customers.Select(c => c.Country).Distinct().ToList();
            ViewBag.countries = countries;

            // search based on country
            //if (countrySearch != null)
            //{
            //customers = customers.Where(c => c.Country == countrySearch);
            //}

            return View(await customers.ToListAsync());
        }

        [Authorize(Roles = "Administrator")]
        public List<Customer> countrySearchResult(string countrySearch)
        {
            var customers = _context.Customers
               .Select(c => c);

            // search based on country
            if (countrySearch != null)
            {
                customers = customers.Where(c => c.Country == countrySearch);
            }
            var result = customers.ToList();
            return (result);
        }

        // GET: Customer/Details/
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.Orders)
                .ThenInclude(o => o.OrderedMovie)
                .FirstOrDefaultAsync(c2 => c2.Username == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customer/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("Username,FirstName,LastName,Country,City,Street,Age,Gender")] Customer customer)
        {

            // linq query to check if a customer is registered
            var customerExists =
               from c in _context.Customers
               where c.Username == customer.Username
               select c;

            if (!customerExists.Any())
            {
                if (ModelState.IsValid)
                {
                    _context.Add(customer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(customer);
            }
            // if the customer user already exists
            else
            {
                ViewBag.Error4 = "Customer Username already exists!";
                return View();
            }
        }

        // GET: Customer/Delete
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            // to prevent attempts to delete users that are not your own, unless you are an admin
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != id))
            {
                return NotFound();
            }
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
               .Include(c => c.Orders)
               .ThenInclude(o => o.OrderedMovie)
               .FirstOrDefaultAsync(c2 => c2.Username == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customer/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(string username)
        {
            // to prevent attempts to delete users that are not your own, unless you are an admin
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != username))
            {
                return NotFound();
            }
            var customer = await _context.Customers
                .Include(c => c.Orders)
                .FirstOrDefaultAsync(c2 => c2.Username == username);

            // delete all the specific customer's orders (order is a weak entity and cannot exist without a valid customer id)
            _context.Orders.RemoveRange(_context.Orders.Where(o => o.CustomerUsername == username));
            //await _context.SaveChangesAsync();

            // delete the customer
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            // if its an admin deleting a different user
            if (User.IsInRole("Administrator") && User.Identity.Name != username)
            {
                return RedirectToAction(nameof(Index));
            }
            // after the user deleted his custoemr page 
            return RedirectToAction("Index", "Home");
        }


        // GET: Customer/Edit
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            // to perevent editing a user that is not your own unless you are an admin
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != id))
            {
                return NotFound();
            }

            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customer/Edit   
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(string username, [Bind("Username,FirstName,LastName,Country,City,Street,Age,Gender")] Customer customer)
        {
            // to perevent editing a user that is not your own unless you are an admin
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != username))
            {
                return NotFound();
            }

            if (username != customer.Username)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Username))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                // if its an admin editting soemone else, redirect him back
                if (User.IsInRole("Administrator"))
                {
                    return RedirectToAction("Index");
                }
            }
            // if its a user edditing himself redirect him to his details page
            return RedirectToAction("DetailsForUser");
        }
        private bool CustomerExists(string username)
        {
            return _context.Customers.Any(c => c.Username == username);
        }




        // GET: Customer/CreateForUser
        [HttpGet]
        [Authorize]
        public IActionResult CreateForUser()
        {
            // linq query to check if a customer is registered
            var customerExists =
               from customer in _context.Customers
               where customer.Username == User.Identity.Name
               select customer;
            // if the user is already registered as a customer then redirect him to his customer details page and display an error
            if (customerExists.Any())
            {
                TempData["error"] = "Already Registered As A Customer";
                return RedirectToAction("DetailsForUser");
            }
            return View();
        }

        // POST: Customer/CreateForUser
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateForUser([Bind("FirstName,LastName,Country,City,Street,Age,Gender")] Customer customer)
        {
            // change the customer username to current username
            customer.Username = User.Identity.Name;
            // linq query to check if a customer is registered
            var customerExists =
               from c in _context.Customers
               where c.Username == User.Identity.Name
               select c;
            if (!customerExists.Any())
            {

                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("DetailsForUser", "Customer");
            }
            // if the customer user already exists
            else
            {
                TempData["error"] = "already registered as a customer!";
                return RedirectToAction("DetailsForUser", "Customer");
            }
        }



        // GET: Customer/DetailsForUser/
        [Authorize]
        public async Task<IActionResult> DetailsForUser()
        {

            var customer = await _context.Customers
                .Include(c => c.Orders)
                .ThenInclude(o => o.OrderedMovie)
                .FirstOrDefaultAsync(c2 => c2.Username == User.Identity.Name);
            if (customer == null)
            {
                TempData["error"] = "please regsiter as a  customer!";
                return RedirectToAction("CreateForUser", "Customer");
            }

            return View(customer);
        }

        // GET: Customer/Map
        public IActionResult Map(string id)
        {
            var customer = _context.Customers.FindAsync(id).Result;
            var address = customer.Street + ", " + customer.City + ", " + customer.Country;
            ViewBag.address = address;
            return View();
        }
    }

    
}