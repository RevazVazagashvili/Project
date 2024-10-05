using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;

namespace Project.DataAccess
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext>options) : base(options) { }
        
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "Se7en", Description = "\"Se7en\" (1995) is a psychological thriller directed by David Fincher," +
                " featuring a grim and intense narrative." +
                " The film stars Brad Pitt as Detective David Mills and Morgan" +
                " Freeman as Detective William Somerset, two detectives on a hunt" +
                " for a serial killer who uses the seven deadly sins as his modus operandi.", Released = 1995 }
            );
        }
    }
}
