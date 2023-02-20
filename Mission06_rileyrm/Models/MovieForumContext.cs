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
        public DbSet<Category> categories { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Superhero"},
                new Category { CategoryID = 2, CategoryName = "Action" },
                new Category { CategoryID = 3, CategoryName = "Comedy" },
                new Category { CategoryID = 4, CategoryName = "Drama" },
                new Category { CategoryID = 5, CategoryName = "Horror" },
                new Category { CategoryID = 6, CategoryName = "Documentary" },
                new Category { CategoryID = 7, CategoryName = "Romantic" },
                new Category { CategoryID = 8, CategoryName = "Thriller" }
                );


            mb.Entity<MovieForumResponse>().HasData(
                new MovieForumResponse
                {
                    MovieForumID = 1,
                    CategoryID = 1,
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
                    CategoryID = 1,
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
                    CategoryID = 2,
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
