using System.Collections.Generic;
using System.Threading.Tasks;
using Bambu.Core.Models;

namespace Bambu.Core.Business
{
    public interface ISalesPersonService
    {
        Task MoveSalesPersonToGroup(int salesPersonId, int groupId);
        Task UpdateSalesPersonContact(Salesperson person);
        Task<List<Salesperson>> GetAllSalesPerson();
    }
}