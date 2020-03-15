using Xunit;
using System.Threading.Tasks;
using Bambu.Core.Models;

namespace Bambu.Data.Test
{
    public class TrackingRepositoryTests
    {
        [Fact]
        public async Task DeletedEntityIsMarkedAndNotRemoved()
        {
            using (var unitOfWork = Helpers.GetUnitOfWork("DeletedEntity"))
            {
                var person = new Salesperson() { Id = 1, Deleted = false };
                await unitOfWork.SalesPerson.AddAsync(person);
                await unitOfWork.Complete();

                await unitOfWork.SalesPerson.DeleteAsync(1);
                await unitOfWork.Complete();
            }

            using (var unitOfWork = Helpers.GetUnitOfWork("DeletedEntity"))
            {
                var person = await unitOfWork.SalesPerson.GetByIDAsync(1);
                Assert.True(person.Deleted, "The person should be marked deleted");
            }
        }
    }
}