using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NearbyFriends.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearbyFriends.Api
{
    public static class StartupExtensions
    {
        public static IApplicationBuilder UseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
                using (var context = serviceScope.ServiceProvider.GetRequiredService<SystemContext>())
                    context.Database.Migrate();

            return app;
        }

        public static IApplicationBuilder CreateUser(
            this IApplicationBuilder app,
            IConfiguration configuration)
        {
            var username = configuration["UserCredentials:UserName"];
            var password = configuration["UserCredentials:Password"];

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                using (var userManager = serviceScope.ServiceProvider.GetService<UserManager<IdentityUser>>())
                {
                    var test = userManager.Users;

                    if (userManager.FindByNameAsync(username).Result == null)
                    {
                        var user = new IdentityUser(username);

                        userManager.CreateAsync(user, password).Wait();
                    }
                }
            }            

            return app;
        }
    }
}
