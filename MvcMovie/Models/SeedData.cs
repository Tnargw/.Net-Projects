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
                    return; // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy",
                        Price = 7.99M,
                        Rating = "PG",
                        ImageName = "TheRM.jpg"
                    },
                    new Movie
                    {
                        Title = "Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-4-12"),
                        Genre = "Drama",
                        Price = 8.99M,
                        Rating = "PG",
                        ImageName = "OtherSideOfHeaven.jpg"
                    },
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Price = 9.99M,
                        Rating = "G",
                        ImageName = "MeetTheMormons.jpg"
                    },
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Drama",
                        Price = 6.99M,
                        Rating = "PG",
                        ImageName = "17Miracles.jpg"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
