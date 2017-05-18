using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public Movie()
        {
            //DateTime dt = new DateTime();
            //ReleaseDate = dt;
            //NumberInStock = 0;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Release date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name =  "Date of added")]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }
        
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int GenderId { get; set; }

    }
}