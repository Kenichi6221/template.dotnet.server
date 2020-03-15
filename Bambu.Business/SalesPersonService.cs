using System.Collections.Generic;
using System.Threading.Tasks;
using Bambu.Core;
using Bambu.Core.Business;
using Bambu.Core.Models;

namespace Bambu.Business
{
    public class SalesPersonService : ISalesPersonService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SalesPersonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Salesperson>> GetAllSalesPerson()
        {
            return await _unitOfWork.SalesPerson.GetAllAsync();
        }

        public async Task MoveSalesPersonToGroup(int salesPersonId, int groupId)
        {
            var person = await _unitOfWork.SalesPerson.GetByIDAsync(salesPersonId);
            var group = await _unitOfWork.SalesGroup.GetByIDAsync(groupId);

            person.SalesGroup = group;

            _unitOfWork.SalesPerson.Update(person);

            await _unitOfWork.Complete();
        }

        public async Task UpdateSalesPersonContact(Salesperson person)
        {
            var existingSalesperson = await _unitOfWork.SalesPerson.GetByIDAsync(person.Id);

            existingSalesperson.FirstName = person.FirstName;
            existingSalesperson.LastName = person.LastName;
            existingSalesperson.Email = person.Email;
            existingSalesperson.Phone = person.Phone;

            _unitOfWork.SalesPerson.Update(existingSalesperson);
            await _unitOfWork.Complete();
        }


    }
}