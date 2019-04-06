using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Movie
    {

        [Key]
        public int MovieID { get; set; }
        public string Name { get; set; }
        public DateTime YearOfRelease { get; set; }
        public string Plot { get; set; }
       public string PosterImagePath { get; set; }
    }
}
