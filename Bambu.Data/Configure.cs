using Bambu.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bambu.Data
{
    public class Configure
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString = "DefaultConnection")
        {
            // dotnet ef --startup-project .\Bambu.Api\Bambu.Api.csproj migrations add migration_alias_ -p .\Bambu.Data\Bambu.Data.csproj
            // dotnet  ef --startup-project  .\Bambu.Api\Bambu.Api.csproj -p .\Bambu.Data\Bambu.Data.csproj database update

            // services
            //     .AddDbContext<BambuDbContext>(options => options.UseInMemoryDatabase("bambudb"));

            services
                 .AddDbContext<BambuDbContext>(
                     options => options
                     .UseSqlServer(connectionString)
                 );

            services
                .AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
