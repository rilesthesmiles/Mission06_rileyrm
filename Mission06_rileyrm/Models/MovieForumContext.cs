using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_rileyrm.Models
{
    public class MovieForumContext : DbContext
    {
        public MovieForumContext (DbContextOptions<MovieForumContext> options) : base (options)
        {
            //Leave Blank For Now
        }

        public DbSet<MovieForumResponse> responses { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieForumResponse>().HasData(
                new MovieForumResponse
                {
                    MovieForumID = 1,
                    Category = "Superhero",
                    Title = "Logan",
                    Year = 2017,
                    Director = "James Mangold",
                    Rating = "R",
                    Edited = true,
                    LentTo = "none",
                    Notes = "Best superhero movie"
                },
                new MovieForumResponse
                {
                    MovieForumID = 2,
                    Category = "Superhero",
                    Title = "Dark Knight",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "none",
                    Notes = "Second best superhero movie"
                },
                new MovieForumResponse
                {
                    MovieForumID = 3,
                    Category = "Action",
                    Title = "Baby Driver",
                    Year = 2017,
                    Director = "Edgar Wright",
                    Rating = "R",
                    Edited = true,
                    LentTo = "none",
                    Notes = "Like Fast and Furious but better"
                }


                );
        }

    }
}
