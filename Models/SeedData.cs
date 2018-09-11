using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies:
                if (context.Movie.Any()) 
                {
                    return; // Db has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-1-11"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "GhostBusters",
                        ReleaseDate = DateTime.Parse("2012-1-1"),
                        Genre = "Horror Comedy",
                        Price = 8.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Johnny Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Cartoon Comedy",
                        Price = 3.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "The Topmost Assasin",
                        ReleaseDate = DateTime.Parse("1965-9-9"),
                        Genre = "Cartoon Comedy",
                        Price = 1.99M,
                        Rating = "PG"
                    }
                );

                context.SaveChanges();

            }
        }
    }
}