using System;
using System.Collections.Generic;
using System.Linq;
using MovieLand.Models;
using MovieLand.Controllers;
using Microsoft.AspNetCore.Identity;
namespace MovieLand.db
{
    public static class DBinit
    {

        public static void Initialize(ShopContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // inssures the db exists
            context.Database.EnsureCreated();

            if (!context.Movies.Any())
            {
                // game list
                var movies = new List<Movie>
                    {
                        // the high game ids are for the steam store catalog, i use steam api to get their prices from the live catalog. the other games are not on steam.
                        new Movie{movieID=1,imdbID="tt0068646", movieName="The Godfather", price="100 NIS", director="Francis Ford Coppola", genre="Drama", year=1972 , trailerID="sY1S34973zA"},
                        new Movie{movieID=2,imdbID="tt0071562", movieName="The Godfather: Part II", price="39 NIS", director="Francis Ford Coppola", genre="Drama", year=1974, trailerID="9O1Iy9od7-A"},
                        new Movie{movieID=3,imdbID="tt0088763", movieName="Back to the Future", price="1 NIS", director="Robert Zemeckis", genre=" Adventure", year=1985, trailerID="qvsgGtivCgs"},
                        new Movie{movieID=4,imdbID="tt0120338", movieName="Titanic", price="80 NIS", director="James Cameron", genre="Drama", year=1997, trailerID ="jUm88F3MEbQ"},
                        new Movie{movieID=5,imdbID="tt0133093", movieName="The Matrix", price="80 NIS", director="The Wachowski Brothers", genre="Action", year=1999, trailerID="vKQi3bBA1y8"},
                        new Movie{movieID=6,imdbID="tt0172495", movieName="Gladiator", price="39 NIS", director="Ridley Scott", genre="Action", year=2000, trailerID="owK1qxDselE"},
                        new Movie{movieID=7,imdbID="tt0391198", movieName="The Grudge", price="200 NIS", director="Takashi Shimizu", genre="Horror", year=2004, trailerID="pJFYq7g6pEk"},
                        new Movie{movieID=8,imdbID="tt0468569", movieName="The Dark Knight", price="1 NIS", director="Christopher Nolan", genre="Action", year=2008, trailerID="EXeTwQWrcwY"},
                        new Movie{movieID=9,imdbID="tt1119646", movieName="The Hangover", price="39 NIS", director="2K", genre="Comedy", year=2009, trailerID="tcdUhdOlz9M"},
                        new Movie{movieID=10,imdbID="tt1130884", movieName="Shutter Island", price="80 NIS", director="Martin Scorsese", genre="Horror", year=2010, trailerID="5iaYLCiq5RM"},
                        new Movie{movieID=11,imdbID="tt0848228", movieName="The Avengers", price="32 NIS", director="Joss Whedon", genre="Action", year=2012, trailerID="eOrNdBpGMv8"},
                        new Movie{movieID=12,imdbID="tt0816692", movieName="Interstellar", price="39 NIS", director="Christopher Nolan", genre="Adventure", year=2014, trailerID="zSWdZVtXT7E"},
                        new Movie{movieID=13,imdbID="tt7131622", movieName="Once Upon a Time... in Hollywood", price="39 NIS", director="Quentin Tarantino", genre="Comedy", year=2019, trailerID="ELeMaP8EPAA"}
                    };
                
                // set prices for steam games from steam database
                foreach (Movie movie in movies)
                {
                    // get price from steam database
                    float rating = GameController.imdbRating(movie.imdbID);
                    movie.rating = rating;
                    
                }
                // insert to games to db context
                movies.ForEach(m => context.Movies.Add(m));
                context.SaveChanges();
            }

            // initialize admin and user roles
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Administrator";
                roleManager.CreateAsync(role);
            }

            if (!roleManager.RoleExistsAsync("NormalUser").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "NormalUser";
                roleManager.CreateAsync(role);
            }

            // initializing an admin and a normal user
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                IdentityUser admin = new IdentityUser();
                admin.UserName = "admin";
                admin.Email = "admin@gmail.com";

                IdentityResult result = userManager.CreateAsync(admin, "Aa123456").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(admin, "Administrator").Wait();
                }
            }

            if (userManager.FindByNameAsync("user1").Result == null)
            {


                IdentityUser user1 = new IdentityUser();
                user1.UserName = "user1";
                user1.Email = "user1@gmail.com";
                IdentityResult result1 = userManager.CreateAsync(user1, "Aa123456").Result;
                if (result1.Succeeded)
                {
                    userManager.AddToRoleAsync(user1, "NormalUser").Wait();
                }


                IdentityUser user2 = new IdentityUser();
                user2.UserName = "user2";
                user2.Email = "user2@gmail.com";
                IdentityResult result2 = userManager.CreateAsync(user2, "Aa123456").Result;
                if (result2.Succeeded)
                {
                    userManager.AddToRoleAsync(user2, "NormalUser").Wait();
                }


                IdentityUser user3 = new IdentityUser();
                user3.UserName = "user3";
                user3.Email = "user3@gmail.com";
                IdentityResult result3 = userManager.CreateAsync(user3, "Aa123456").Result;
                if (result3.Succeeded)
                {
                    userManager.AddToRoleAsync(user3, "NormalUser").Wait();
                }


                IdentityUser user4 = new IdentityUser();
                user4.UserName = "user4";
                user4.Email = "user4@gmail.com";
                IdentityResult result4 = userManager.CreateAsync(user4, "Aa123456").Result;
                if (result4.Succeeded)
                {
                    userManager.AddToRoleAsync(user4, "NormalUser").Wait();
                }
            }

            if (!context.Customers.Any())
            {
                // customer list
                var customers = new List<Customer>
                {
                    new Customer{Username="user1", FirstName="moshe", LastName="benzvi", Country="USA", City="New York", Street="Brooklyn Bridge", Age=16, Gender = Gender.Male},
                    new Customer{Username="user2", FirstName="tal", LastName="chohen", Country="England", City="London", Street="Oxford 3", Age=53, Gender = Gender.Female},
                    new Customer{Username="user3", FirstName="bobo", LastName="cami", Country="England", City="London", Street="Oxford 10", Age=35, Gender = Gender.Male},
                    new Customer{Username="user4", FirstName="joe", LastName="smith", Country="Israel", City="Ramat Gan", Street="Yasmin 4", Age=13, Gender = Gender.Male}

                };

                // insert to customers to db context
                customers.ForEach(c => context.Customers.Add(c));
                context.SaveChanges();
            }

            // avoiding db crash if trying to add these orders if the defualt games or customer were deleted
            var defualtCustomer1 = context.Customers.Find("user1");
            var defualtCustomer2 = context.Customers.Find("user2");
            var defualtGame1 = context.Movies.Find(3);
            var defualtGame2 = context.Movies.Find(4);
            var defualtGame3 = context.Movies.Find(8);

            if (!context.Orders.Any() && defualtCustomer1 != null && defualtCustomer2 != null && defualtGame1 != null && defualtGame2 != null && defualtGame3 != null)
            {
                var orders = new List<Order>
                    {
                        new Order{CustomerUsername="user1", movieID=3, OrderDate=DateTime.Parse("2020-12-1")},
                        new Order{CustomerUsername="user1", movieID=4, OrderDate=DateTime.Parse("2020-12-1")},
                        new Order{CustomerUsername="user2", movieID=8, OrderDate=DateTime.Parse("2020-12-1")}

                    };

                // insert to orders to db context
                orders.ForEach(o => context.Orders.Add(o));
                context.SaveChanges();


            }

        }
    }

}
