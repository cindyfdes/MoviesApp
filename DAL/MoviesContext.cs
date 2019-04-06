using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Models;

namespace DAL
{
    public static class BaseContext
    {
        public static string value { get; set; }
    }
    public  class MoviesContext:DbContext
    {
        public MoviesContext() : base(BaseContext.value) { }
        public DbSet<Movie> Movies { get; set; } 
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
