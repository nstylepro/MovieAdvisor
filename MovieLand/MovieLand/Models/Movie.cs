using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLand.Models
{
    // only an admin can create or edit this models ttributes so the field validation is a bit less strict
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]        
        [Required]
        public int movieID { get; set; }

        [Required]
        public string imdbID { get; set; }

        [Required]
        public string movieName { get; set; }

        [Required]
        public int year { get; set; }

        [Required]
        public float rating { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "price cannot be longer than 10 characters.")]
        [RegularExpression(@"^\d+\sNIS$", ErrorMessage = "correct format is: xxxx NIS")]
        public string price { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Director's name cannot be longer than 30 characters.")]
        public string director { get; set; }

        [Required]
        [RegularExpression(@"^(\w+\,\w+){0,}$", ErrorMessage = "correct format is: xxxx,xxxx,...")]
        public string genre { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Trailer cannot be longer than 20 characters.")]
        public string trailerID { get; set; }
    }
}
