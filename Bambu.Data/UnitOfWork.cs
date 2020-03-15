using System.Threading.Tasks;
using Bambu.Core;
using Bambu.Core.Models;
using Bambu.Core.Repositories;
using Bambu.Data.Repositories;

namespace Bambu.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BambuDbContext _context;
        public ISalesPersonRepository SalesPerson { get; private set; }

        public ITrackingRepository<SalesGroup> SalesGroup { get; private set; }

        public UnitOfWork(BambuDbContext context)
        {
            _context = context;
            SalesPerson = new SalesPersonRepository(context);
            SalesGroup = new TrackingRepository<SalesGroup>(context);
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