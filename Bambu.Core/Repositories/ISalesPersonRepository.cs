using System.Collections.Generic;
using System.Threading.Tasks;
using Bambu.Core.Models;

namespace Bambu.Core.Repositories
{
    public interface ISalesPersonRepository : ITrackingRepository<Salesperson>
    {
        Task<List<Salesperson>> GetSalesPeopleByStateGroup(string state);
    }
}