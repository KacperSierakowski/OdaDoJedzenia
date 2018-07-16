using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nauka3.Models
{
    public class RestaurantReview
    {

        public int Id { get; set; }
        //public string Name { get; set; }
       // public string City { get; set; }
       // public string Country { get; set; }
       [Range(1,10)]
       [Required]
        public int Rating { get; set; }
        [Required]
        [StringLength(1000)]
        public string Body { get; set; }
        [Display(Name ="User Name")]
        [DisplayFormat(NullDisplayText ="anonim")]
        public string ReviewerName { get; set; }
        public int RestaurantID { get; set; }


    }
}