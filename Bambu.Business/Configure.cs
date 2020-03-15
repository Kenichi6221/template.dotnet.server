using Bambu.Core.Business;
using Microsoft.Extensions.DependencyInjection;

namespace Bambu.Business
{
    public static class Configure
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddTransient<ISalesPersonService, SalesPersonService>();
        }
    }
}
