using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieLand.ViewModels;
using MovieLand.db;
using Microsoft.EntityFrameworkCore;

namespace MovieLand.Controllers
{
    using MovieLand.db;
    using MovieLand.ViewModels;

    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ShopContext _context;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager, ShopContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            _context = context;
        }

        // GET/Register
        [HttpGet]      
        public IActionResult Register()
        {
            return View();
        }

        // POST/Register
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Username, Email = model.Email};
                var result = await userManager.CreateAsync(user, model.Password);

                if(result.Succeeded)
                {
                    // add to normal user role
                    userManager.AddToRoleAsync(user, "NormalUser").Wait();

                    // change isPersistent if  you want to keep cookie after close
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        // GET/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST/Login
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                // last parameter is for lockout
                var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    // if the user tried was prompted login after trying to view a page, return him to the page he tried to view
                    // using is local url to prevent open redirect vulnerability
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {  
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }                  
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid Username Or Password");
                }
            }
            return View(model);
        }

        // POST/Logout
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        // GET/List
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<ActionResult> List()
        {
            
            var allUsers = userManager.Users;
            var userViewModel = new List<UserViewModel>();

            // get users then create user view model from them
            var users = await allUsers
                        .Select(user => new UserViewModel
                        {
                            Id = user.Id,
                            UserName = user.UserName,
                            Email = user.Email,
                        }).ToListAsync();

            // add roles data
            foreach (var u in users)
            {              
                var Role = (await userManager.GetRolesAsync(u))[0];
                u.Role = Role;
            }
            
            return View(users);
        }


        [Authorize(Roles ="Administrator")]
        [HttpGet]
        // GET: Account/MakeAdmin
        public async Task<IActionResult> MakeAdmin(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await userManager.FindByNameAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                // just in case he is already an administrator
                var role = (await userManager.GetRolesAsync(user))[0];
                if (role== "NormalUser")
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                    userManager.RemoveFromRoleAsync(user, "NormalUser").Wait();
                }
               
            }
            return RedirectToAction("List", "Account");
        }


        // GET: Account/Delete
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

            // get the use of given username
            var user = await userManager.FindByNameAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            
            return View(user);
        }

        // POST: Account/Delete
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
            // get the use of given username
            var user = await userManager.FindByNameAsync(username);
            // get customer of given username
            var customer = await _context.Customers
               .Include(c => c.Orders)
               .FirstOrDefaultAsync(c2 => c2.Username == username);

            if (customer != null)
            {
                // delete all the specific user's data (customer page + orders)           
                _context.Orders.RemoveRange(_context.Orders.Where(o => o.CustomerUsername == username));
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }

            // delete the user
            var result = await userManager.DeleteAsync(user);
            
            if (result.Succeeded)
            {
                // if the logged in user deletes himself log him out 
                if (User.Identity.Name == username)
                {
                    await signInManager.SignOutAsync();
                    return RedirectToAction("Index", "Home");
                }
                // if its admin deleting a different user
                return RedirectToAction("List");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }        
            return RedirectToAction("List");
        }

        // GET: Account/DetailsForUser
        [Authorize]
        public async Task<IActionResult> DetailsForUser()
        {
                       
            // get the user of given username
            var user = await userManager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }




        // GET: Account/Edit
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            // to prevent editing a user that is not your own unless you are an admin
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != id))
            {
                return NotFound();
            }

            if (id == null)
            {
                return NotFound();
            }

            var user = await userManager.FindByNameAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Account/Edit   
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(string username, string email)
        {
            var user = await userManager.FindByNameAsync(username);
            // to prevent editing a user that is not your own unless you are an admin
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != user.UserName))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (IsValidEmail(email))
                    {
                        user.Email = email;
                    }
                    else
                    {
                        ViewBag.Error5 = "not email format";
                        return View();
                    }
                    // Persist the changes
                    await userManager.UpdateAsync(user);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserName))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                // if its an admin editing someone else, redirect him back
                if (User.IsInRole("Administrator"))
                {
                    return RedirectToAction("List");
                }
            }
            // if its a user editing himself redirect him to his details page
            return RedirectToAction("DetailsForUser");
        }

        private bool UserExists(string username)
        {
            return (userManager.FindByNameAsync(username)!=null);
        }

        // GET: Account/ChangePassword
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ChangePassword(string id)
        {
            // to prevent editing a user that is not your own unless you are an admin
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != id))
            {
                return NotFound();
            }

            if (id == null)
            {
                return NotFound();
            }

            var user = await userManager.FindByNameAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var viewUser = new UserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
            };

            return View(viewUser);
        }

        // POST: Account/ChangePassword   
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> ChangePassword(string username, string password)
        {
            var user = await userManager.FindByNameAsync(username);
            // to prevent editing a user that is not your own unless you are an admin
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != user.UserName))
            {
                return NotFound();
            }
            // check if given password matches complexity
            if (!CheckPasswordComplexity(password))
            {
                ViewBag.Error6 = "password doesnt match complexity (1 num, 1 upper, 1 lower, 6 len)";
                return View();
            }
            if (ModelState.IsValid)
            {               
                string resetToken = await userManager.GeneratePasswordResetTokenAsync(user);
                await userManager.ResetPasswordAsync(user, resetToken, password);
               
            }
                 
            // if its an admin editing someone else, redirect him back
            if (User.IsInRole("Administrator") && (User.Identity.Name != user.UserName))
            {
                return RedirectToAction("List");
            }

            // if the logged in user resets his password log him out           
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        // gets string and checks if its in email format
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // check if string matches pass complexity
        bool CheckPasswordComplexity(string text)
        {
            var hasUpperCase = text.Any(char.IsUpper);
            var hasLowerCase = text.Any(char.IsLower);
            var hasDigits = text.Any(char.IsDigit);
            
            if (text.Length<6)
            {
                return false;
            }
            if (!hasUpperCase)
            {
                return false;
            }
            else if (!hasLowerCase)
            {
                return false;
            }
            else if (!hasDigits)
            {
                return false;
            }
            return true;
        }
    }
}