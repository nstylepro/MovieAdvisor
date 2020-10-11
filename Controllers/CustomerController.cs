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

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index(string countrySearch)
        {
            var customers = _context.Customers
                .Select(c => c);
            var countries = _context.Customers.Select(c => c.Country).Distinct().ToList();
            ViewBag.countries = countries;

            return View(await customers.ToListAsync());
        }

        [Authorize(Roles = "Administrator")]
        public List<Customer> countrySearchResult(string countrySearch)
        {
            var customers = _context.Customers
               .Select(c => c);

            if (countrySearch != null)
            {
                customers = customers.Where(c => c.Country == countrySearch);
            }
            var result = customers.ToList();
            return (result);
        }

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

        
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("Username,FirstName,LastName,Country,City,Street,Age,Gender")] Customer customer)
        {

           
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
            
            else
            {
                ViewBag.Error4 = "Customer Username already exists!";
                return View();
            }
        }

       
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            
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

           
            _context.Orders.RemoveRange(_context.Orders.Where(o => o.CustomerUsername == username));
          
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

           
            if (User.IsInRole("Administrator") && User.Identity.Name != username)
            {
                return RedirectToAction(nameof(Index));
            }
            
            return RedirectToAction("Index", "Home");
        }


      
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            
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

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(string username, [Bind("Username,FirstName,LastName,Country,City,Street,Age,Gender")] Customer customer)
        {
          
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
               
                if (User.IsInRole("Administrator"))
                {
                    return RedirectToAction("Index");
                }
            }
           
            return RedirectToAction("DetailsForUser");
        }
        private bool CustomerExists(string username)
        {
            return _context.Customers.Any(c => c.Username == username);
        }




        
        [HttpGet]
        [Authorize]
        public IActionResult CreateForUser()
        {
           
            var customerExists =
               from customer in _context.Customers
               where customer.Username == User.Identity.Name
               select customer;
           
            if (customerExists.Any())
            {
                TempData["error"] = "Already Registered As A Customer";
                return RedirectToAction("DetailsForUser");
            }
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateForUser([Bind("FirstName,LastName,Country,City,Street,Age,Gender")] Customer customer)
        {
            
            customer.Username = User.Identity.Name;
           
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
            
            else
            {
                TempData["error"] = "already registered as a customer!";
                return RedirectToAction("DetailsForUser", "Customer");
            }
        }
       
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
       
        public IActionResult Map(string id)
        {
            var customer = _context.Customers.FindAsync(id).Result;
            var address = customer.Street + ", " + customer.City + ", " + customer.Country;
            ViewBag.address = address;
            return View();
        }
    }

    
}