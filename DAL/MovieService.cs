using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class MovieService
    {
        MoviesContext context = new MoviesContext();
        public MovieService() { }
        public List<Movie> GetAllMovies()
        {
           return context.Movies.ToList();
        }
    }
}
