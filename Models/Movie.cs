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
        [StringLength(9, ErrorMessage = "ImdbID cannot be longer than 9 characters.")]
        public string ImdbID { get; set; }

        [Required]
        public string MovieName { get; set; }

        [Required]
        [RegularExpression(@"(\d){4}", ErrorMessage = "Correct format is: xxxx")]
        public int Year { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Price cannot be longer than 10 characters.")]
        [RegularExpression(@"^\d+\sNIS$", ErrorMessage = "Correct format is: xxxx NIS")]
        public string Price { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Director cannot be longer than 30 characters.")]
        public string Director { get; set; }

        [Required]
        public float Rating { get; set; }

        [Required]

        public string Genre { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "company cannot be longer than 30 characters.")]
        public string TrailerID { get; set; }

    }
}
