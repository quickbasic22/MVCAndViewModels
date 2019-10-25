using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAndViewModels.ViewModels
{
    public class MovieViewModel
    {
        public List<String> ListOfGenres { get; set; }
        public List<String> ListOfRatings{ get; set; }
        public List<String> Theatre { get; set; }
        public string Time { get; set; }

        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Genre must be specified")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Price required")]
        [Range(1, 100, ErrorMessage = "Price must be between $1 and $100")] 
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        [StringLength(5)]
        public string Rating { get; set; }
    }
}