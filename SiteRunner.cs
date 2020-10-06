using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MovieLand.db;
using Microsoft.AspNetCore.Identity;

namespace MovieLand
{
    using MovieLand.db;

    public class SiteRunner
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
              
                var context = services.GetRequiredService<ShopContext>();

                //Clear DB in every run
                context.Database.EnsureDeleted();

                //initialize customers
                var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
      
                DBinit.Initialize(context, userManager, roleManager);
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
