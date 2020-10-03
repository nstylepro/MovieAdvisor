﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieLand.Models
{
    // only an admin can create or edit this models attributes so the field validation is a bit less strict
    public class Order
    {
        [Required]
        public int OrderID { get; set; }

        [Required]
        [RegularExpression("([a-zA-Z0-9_]+)", ErrorMessage = "Only Alpha Numeric Chars!")]
        [StringLength(15, ErrorMessage = "username cannot be longer than 15 characters.")]
        public string CustomerUsername { get; set; }       
        [Required]       
        public int movieID { get; set; }
       
        // these are added automatically after the order is created
        public virtual Movie OrderedMovie { get; set; }    
        public virtual Customer Buyer { get; set; }

        // this is validated in the html
        [Required]
        public DateTime OrderDate { get; set; }
    }
}
