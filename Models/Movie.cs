using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand.Models
{
    // only an admin can create or edit this models ttributes so the field validation is a bit less strict
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]        
        [Required]
        public int MovieID { get; set; }

        [Required]
        public string ImdbID { get; set; }

        [Required]
        public string MovieName { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "price cannot be longer than 10 characters.")]
        [RegularExpression(@"^\d+\sNIS$", ErrorMessage = "correct format is: xxxx NIS")]
        public string Price { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "company cannot be longer than 30 characters.")]
        public string Director { get; set; }

        [Required]
        public float Rating { get; set; }

        [Required]
        [RegularExpression(@"^(\w+\,\w+){0,}$", ErrorMessage = "correct format is: xxxx,xxxx,...")]
        public string Genre { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "company cannot be longer than 30 characters.")]
        public string TrailerID { get; set; }

    }
}
