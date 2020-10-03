using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand.ViewModels
{
    public class RegisterViewModel
    {
        [Required] 
        [RegularExpression("([a-zA-Z0-9_]+)", ErrorMessage ="Only Alpha NUmeric Chars!")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name= "Confirm Password")]
        [Compare("Password", ErrorMessage ="Passwords Do Not Match")]
        public string ConfirmPassword { get; set; }

    }
}
