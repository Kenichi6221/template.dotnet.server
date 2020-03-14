using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bambu.Core.Models;
using Bambu.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bambu.Data.Repositories
{
    public class SalesPersonRepository : TrackingRepository<Salesperson>, ISalesPersonRepository
    {
        public SalesPersonRepository(BambuDbContext context) : base(context) { }

        public Task<List<Salesperson>> GetSalesPeopleByStateGroup(string state)
        {
            return _context.Set<Salesperson>().Where(s => s.SalesGroup.State == state).ToListAsync();
        }
    }
}