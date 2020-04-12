using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace PinArt_ProfileInfo_MS.Models
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<InfoContext>());
            }
        }

        public static void SeedData(InfoContext context)
        {
            System.Console.WriteLine("Appling Migrations... ");

            context.Database.Migrate();
        }
    }
}