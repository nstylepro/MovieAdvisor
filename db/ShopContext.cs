using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace MovieLand.db
{
    using MovieLand.Models;

    public class ShopContext : IdentityDbContext 
    {
        // what is this?
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        // db items
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

    
}
