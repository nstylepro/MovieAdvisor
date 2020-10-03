using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand.Models
{
    public enum Gender {Male, Female};
    public class Customer
    {

        [Key]
        [Required]
        [StringLength(15, ErrorMessage = "username cannot be longer than 15 characters.")]
        [RegularExpression("([a-zA-Z0-9_]+)", ErrorMessage = "Only Alpha NUmeric Chars!")]
        public string Username { get; set; }       

        [Required]
        [StringLength(20, ErrorMessage = "name cannot be longer than 20 characters.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "name cannot be longer than 20 characters.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string LastName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "city cannot be longer than 30 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only please")]
        public string City { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "country cannot be longer than 30 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only please")]
        public string Country { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "street cannot be longer than 30 characters.")]
        [RegularExpression(@"^[\w\s]+$", ErrorMessage = "no special characters")]
        public string Street { get; set; }
        [Required]
        [Range(5, 120, ErrorMessage = "age must be between 5-120")]
        public int Age { get; set; }
        [Required]
        public Gender Gender { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
