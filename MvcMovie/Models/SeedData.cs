using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-03"),
                        Genre = "Adventure/History",
                        Price = 12.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-13"),
                        Genre = "Drama",
                        Price = 10.99M, 
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven 2",
                        ReleaseDate = DateTime.Parse("2019-6-28"),
                        Genre = "Drama",
                        Price = 19.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-2-1"),
                        Genre = "Comedy",
                        Price = 8.99M, 
                        Rating = "PG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}