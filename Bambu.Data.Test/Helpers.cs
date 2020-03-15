using Bambu.Core;
using Microsoft.EntityFrameworkCore;

namespace Bambu.Data.Test
{
    public static class Helpers
    {
        public static IUnitOfWork GetUnitOfWork(string name)
        {
            var dbOptions = new DbContextOptionsBuilder<BambuDbContext>()
                .UseInMemoryDatabase(name).Options;
            var dbContext = new BambuDbContext(dbOptions);

            var unitOfWork = new UnitOfWork(dbContext);
            return unitOfWork;
        }
    }
}