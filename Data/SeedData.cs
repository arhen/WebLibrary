using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WebLibrary.Models;

namespace WebLibrary.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebLibraryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebLibraryContext>>()))
            {
                // Look for any Books.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "A Game Of Thrones",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Action and Thiller",
                        Price = 160000
                    },

                    new Book
                    {
                        Title = "A Clash of Kings",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Action and Thiller",
                        Price = 160000
                    },

                    new Book
                    {
                        Title = "A Storm of Swords",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Action and Thiller",
                        Price = 140000
                    },

                    new Book
                    {
                        Title = "Harry Potter and the Sorcerer's Stone",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Folk",
                        Price = 200000
                    },

                    new Book
                    {
                        Title = "Harry Potter and the Deathly Hallows ",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Folk and Horror",
                        Price = 210000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}