using System.Threading.Tasks;
using Bambu.Core;
using Bambu.Core.Repositories;
using Bambu.Data.Repositories;

namespace Bambu.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BambuDbContext _context;
        public ISalesPersonRepository SalesPerson { get; private set; }
        public UnitOfWork(BambuDbContext context)
        {
            _context = context;
            SalesPerson = new SalesPersonRepository(context);
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}