using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practice1303.Models;

namespace Practice1303.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
