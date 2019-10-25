using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAndViewModels.ViewModels
{
    public class MovieListItemViewModel
    {
        DateTime _ReleaseDate;
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string DayOfRelease
        {
            get
            {
                return ReleaseDate.DayOfWeek.ToString() + " " + ReleaseDate.ToShortDateString();
            }
        }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public string AllTimes { get; set; }
    }
}