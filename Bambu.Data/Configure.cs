using Microsoft.Extensions.DependencyInjection;

namespace Bambu.Data
{
    public class Configure
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            //Context lifetime defaults to "scoped"
            // services
            //      .AddDbContext<DbContext>(options => options.UseSqlServer(connectionString));

            // services
            //     .AddScoped<InterfazFromCore, ConcreteClassInDataProject>()
        }
    }
}
