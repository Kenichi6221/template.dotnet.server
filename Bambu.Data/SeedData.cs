using System;
using System.Threading.Tasks;
using Bambu.Core.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Bambu.Data
{
    public class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            await AddSalespersons(services.GetRequiredService<BambuDbContext>());
        }

        private static async Task AddSalespersons(BambuDbContext context)
        {
            await context.Salesperson.AddAsync(new Salesperson
            {
                Email = "jhon.doe@email.com",
                CreatedDate = DateTime.Now,
                FirstName = "Jhon",
                LastName = "Doe",
                Phone = "317456789"
            });

            await context.SaveChangesAsync();
        }
    }
}