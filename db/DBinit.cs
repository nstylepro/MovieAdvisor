using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace MovieLand.db
{
    using MovieLand.Controllers;
    using MovieLand.Models;

    public static class DBinit
    {
        public static void Initialize(ShopContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // inssures the db exists
            context.Database.EnsureCreated();

            if (!context.Movies.Any())
            {
                // movie list
                var movies = new List<Movie>
                    {
                        // the high Movie ids are for the steam store catalog, i use steam api to get their Prices from the live catalog. the other Movies are not on steam.
                        new Movie{MovieID=1,ImdbID="tt0068646", MovieName="The Godfather", Price="100 NIS", Director="Francis Ford Coppola", Genre="Drama", Year=1972 , TrailerID="sY1S34973zA"},
                        new Movie{MovieID=2,ImdbID="tt0071562", MovieName="The Godfather: Part II", Price="39 NIS", Director="Francis Ford Coppola", Genre="Drama", Year=1974, TrailerID="9O1Iy9od7-A"},
                        new Movie{MovieID=3,ImdbID="tt0088763", MovieName="Back to the Future", Price="1 NIS", Director="Robert Zemeckis", Genre=" Adventure", Year=1985, TrailerID="qvsgGtivCgs"},
                        new Movie{MovieID=4,ImdbID="tt0120338", MovieName="Titanic", Price="80 NIS", Director="James Cameron", Genre="Drama", Year=1997, TrailerID ="jUm88F3MEbQ"},
                        new Movie{MovieID=5,ImdbID="tt0133093", MovieName="The Matrix", Price="80 NIS", Director="The Wachowski Brothers", Genre="Action", Year=1999, TrailerID="vKQi3bBA1y8"},
                        new Movie{MovieID=6,ImdbID="tt0172495", MovieName="Gladiator", Price="39 NIS", Director="Ridley Scott", Genre="Action", Year=2000, TrailerID="owK1qxDselE"},
                        new Movie{MovieID=7,ImdbID="tt0391198", MovieName="The Grudge", Price="200 NIS", Director="Takashi Shimizu", Genre="Horror", Year=2004, TrailerID="pJFYq7g6pEk"},
                        new Movie{MovieID=8,ImdbID="tt0468569", MovieName="The Dark Knight", Price="1 NIS", Director="Christopher Nolan", Genre="Action", Year=2008, TrailerID="EXeTwQWrcwY"},
                        new Movie{MovieID=9,ImdbID="tt1119646", MovieName="The Hangover", Price="39 NIS", Director="Todd Phillips", Genre="Comedy", Year=2009, TrailerID="tcdUhdOlz9M"},
                        new Movie{MovieID=10,ImdbID="tt1130884", MovieName="Shutter Island", Price="80 NIS", Director="Martin Scorsese", Genre="Horror", Year=2010, TrailerID="5iaYLCiq5RM"},
                        new Movie{MovieID=11,ImdbID="tt0848228", MovieName="The Avengers", Price="32 NIS", Director="Joss Whedon", Genre="Action", Year=2012, TrailerID="eOrNdBpGMv8"},
                        new Movie{MovieID=12,ImdbID="tt0816692", MovieName="Interstellar", Price="39 NIS", Director="Christopher Nolan", Genre="Adventure", Year=2014, TrailerID="zSWdZVtXT7E"},
                        new Movie{MovieID=13,ImdbID="tt7131622", MovieName="Once Upon a Time... in Hollywood", Price="39 NIS", Director="Quentin Tarantino", Genre="Comedy", Year=2019, TrailerID="ELeMaP8EPAA"}
                    };

                // insert to Movies to db context
                movies.ForEach(movie => context.Movies.Add(movie));
                context.SaveChanges();
            }

            foreach (Movie movie in context.Movies.ToList())
            {
                //Set updated rating from imdb
                float rating = MovieController.imdbRating(movie.ImdbID);
                movie.Rating = rating;
            }

            context.SaveChanges();

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

                IdentityResult result = userManager.CreateAsync(admin, "Aa10082020").Result;

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
                IdentityResult result1 = userManager.CreateAsync(user1, "Aa10082020").Result;
                if (result1.Succeeded)
                {
                    userManager.AddToRoleAsync(user1, "NormalUser").Wait();
                }

                IdentityUser user2 = new IdentityUser();
                user2.UserName = "user2";
                user2.Email = "user2@gmail.com";
                IdentityResult result2 = userManager.CreateAsync(user2, "Aa10082020").Result;
                if (result2.Succeeded)
                {
                    userManager.AddToRoleAsync(user2, "NormalUser").Wait();
                }

                IdentityUser user3 = new IdentityUser();
                user3.UserName = "user3";
                user3.Email = "user3@gmail.com";
                IdentityResult result3 = userManager.CreateAsync(user3, "Aa10082020").Result;
                if (result3.Succeeded)
                {
                    userManager.AddToRoleAsync(user3, "NormalUser").Wait();
                }

                IdentityUser user4 = new IdentityUser();
                user4.UserName = "user4";
                user4.Email = "user4@gmail.com";
                IdentityResult result4 = userManager.CreateAsync(user4, "Aa10082020").Result;
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
                    new Customer{Username="user1", FirstName="Nimrod", LastName="Nstyle", Country="Russia", City="Moscow", Street="Tverskaya 1", Age=26, Gender = Gender.Male},
                    new Customer{Username="user2", FirstName="Avinoam", LastName="Nini", Country="Israel", City="Tel Aviv", Street="rothschild 33", Age=33, Gender = Gender.Female},
                    new Customer{Username="user3", FirstName="Shushan", LastName="Cohen", Country="England", City="London", Street="Oxford 10", Age=65, Gender = Gender.Male},
                    new Customer{Username="user4", FirstName="MTAFC", LastName="Goldhar", Country="Israel", City="Ramat Efal", Street="HaYasmin 1", Age=17, Gender = Gender.Male}

                };

                // insert to customers to db context
                customers.ForEach(c => context.Customers.Add(c));
                context.SaveChanges();
            }

            // avoiding db crash if trying to add these orders if the defualt Movies or customer were deleted
            var defualtCustomer1 = context.Customers.Find("user1");
            var defualtCustomer2 = context.Customers.Find("user2");
            var defualtMovie1 = context.Movies.Find(3);
            var defualtMovie2 = context.Movies.Find(4);
            var defualtMovie3 = context.Movies.Find(8);

            if (!context.Orders.Any() && defualtCustomer1!=null && defualtCustomer2 != null && defualtMovie1!=null && defualtMovie2!=null && defualtMovie3!=null)
            {
                    var orders = new List<Order>
                    {
                        new Order{CustomerUsername="user1", MovieID=3, OrderDate=DateTime.Parse("2020-12-11")},
                        new Order{CustomerUsername="user1", MovieID=7, OrderDate=DateTime.Parse("2020-01-01")},
                        new Order{CustomerUsername="user2", MovieID=5, OrderDate=DateTime.Parse("2020-08-08")}

                    };

                // insert to orders to db context
                orders.ForEach(o => context.Orders.Add(o));
                context.SaveChanges();
            }
          
        }
    }
    
}
