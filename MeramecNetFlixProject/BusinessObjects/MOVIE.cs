using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeramecNetFlixProject.BusinessObjects
{
    public class MOVIE
    {
        public string movie_number { get; set; }
        public string movie_title { get; set; }
        public string Description { get; set; }
        public string movie_year_made { get; set; }
        public string genre_id { get; set; }
        public string movie_rating { get; set; }
        public string movie_retail_cost { get; set; }
        public string copies_on_hand { get; set; }
        public string image { get; set; }
        public string trailer { get; set; }
        public MOVIE() { }
    }
}
