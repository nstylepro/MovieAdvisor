using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieLand.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [RegularExpression("([a-zA-Z0-9_]+)", ErrorMessage = "Only Alpha Numeric Chars!")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}