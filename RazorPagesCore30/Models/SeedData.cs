using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesCore30.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesCore30Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesCore30Context>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Iron Man",
                        ReleaseDate = DateTime.Parse("2008-05-02"),
                        Genre = "Action",
                        Price = 19.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Iron Man 2",
                        ReleaseDate = DateTime.Parse("2010-05-07"),
                        Genre = "Action",
                        Price = 19.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Iron Man 3",
                        ReleaseDate = DateTime.Parse("2013-05-03"),
                        Genre = "Action",
                        Price = 19.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Avengers: Endgame",
                        ReleaseDate = DateTime.Parse("2019-04-26"),
                        Genre = "Epic Action",
                        Price = 19.99M,
                        Rating = "PG-13"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}