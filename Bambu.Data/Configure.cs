using Bambu.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bambu.Data
{
    public class Configure
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {

            services
                 .AddDbContext<BambuDbContext>(options => options.UseInMemoryDatabase("bambudb"));

            services
                .AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
