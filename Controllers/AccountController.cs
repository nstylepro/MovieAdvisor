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

        [HttpGet]      
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Username, Email = model.Email};
                var result = await userManager.CreateAsync(user, model.Password);

                if(result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "NormalUser").Wait();

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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
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

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<ActionResult> List()
        {
            
            var allUsers = userManager.Users;
            var userViewModel = new List<UserViewModel>();

            var users = await allUsers
                        .Select(user => new UserViewModel
                        {
                            Id = user.Id,
                            UserName = user.UserName,
                            Email = user.Email,
                        }).ToListAsync();

            foreach (var u in users)
            {              
                var Role = (await userManager.GetRolesAsync(u))[0];
                u.Role = Role;
            }
            
            return View(users);
        }


        [Authorize(Roles ="Administrator")]
        [HttpGet]
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
                var role = (await userManager.GetRolesAsync(user))[0];
                if (role== "NormalUser")
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                    userManager.RemoveFromRoleAsync(user, "NormalUser").Wait();
                }
               
            }
            return RedirectToAction("List", "Account");
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

            var user = await userManager.FindByNameAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(string username)
        {
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != username))
            {
                return NotFound();
            }
            var user = await userManager.FindByNameAsync(username);
            var customer = await _context.Customers
               .Include(c => c.Orders)
               .FirstOrDefaultAsync(c2 => c2.Username == username);

            if (customer != null)
            {        
                _context.Orders.RemoveRange(_context.Orders.Where(o => o.CustomerUsername == username));
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }

            var result = await userManager.DeleteAsync(user);
            
            if (result.Succeeded)
            {
                if (User.Identity.Name == username)
                {
                    await signInManager.SignOutAsync();
                    return RedirectToAction("Index", "Home");
                }
                return RedirectToAction("List");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }        
            return RedirectToAction("List");
        }

        [Authorize]
        public async Task<IActionResult> DetailsForUser()
        {
                       
            var user = await userManager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpGet]
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

            var user = await userManager.FindByNameAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(string username, string email)
        {
            var user = await userManager.FindByNameAsync(username);
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
                if (User.IsInRole("Administrator"))
                {
                    return RedirectToAction("List");
                }
            }
            return RedirectToAction("DetailsForUser");
        }

        private bool UserExists(string username)
        {
            return (userManager.FindByNameAsync(username)!=null);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ChangePassword(string id)
        {
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> ChangePassword(string username, string password)
        {
            var user = await userManager.FindByNameAsync(username);
            if ((!User.IsInRole("Administrator")) && (User.Identity.Name != user.UserName))
            {
                return NotFound();
            }
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
                 
            if (User.IsInRole("Administrator") && (User.Identity.Name != user.UserName))
            {
                return RedirectToAction("List");
            }
     
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

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