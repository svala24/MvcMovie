using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using MvcMovie.Migrations;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "Iboy",
                    ReleaseDate = DateTime.Parse("2017-01-27"),
                    Genre = "Sci-Fi",
                    Price = 90.00M,
                    Rating = "A",
                },
                new Movie
                {
                    Title = "Snowden ",
                    ReleaseDate = DateTime.Parse("2013-02-23"),
                    Genre = "Sci-Fi",
                    Price = 90.00M,
                    Rating = "A",
                },
                new Movie
                {
                    Title = "Prinson Break",
                    ReleaseDate = DateTime.Parse("2015-02-10"),
                    Genre = "Thriller",
                    Price = 89.00M,
                    Rating = "8",
                },
                new Movie
                {
                    Title = "Sully",
                    ReleaseDate = DateTime.Parse("2016-09-09"),
                    Genre = "Drama, Biography",
                    Price = 99.00M, 
                    Rating = "A",
                },
                new Movie
                {
                    Title = "Outer Banks",
                    ReleaseDate = DateTime.Parse("2020-04-15"),
                    Genre = "Action Crime",
                    Price = 80.00M, 
                    Rating = "A",
                }
            );
            context.SaveChanges();
        }
    }
}