using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.BusinessObjects
{
    public class GENRE 
    {
        public string id { get; set; }
        public string name { get; set; }

        public GENRE() { }     

        //public static void GetGenreList()
        //{
        //    GenreDB.GetGenreList();            
        //}
    }
    
}
