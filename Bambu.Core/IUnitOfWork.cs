using System;
using System.Threading.Tasks;
using Bambu.Core.Models;
using Bambu.Core.Repositories;

namespace Bambu.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ISalesPersonRepository SalesPerson { get; }

        ITrackingRepository<SalesGroup> SalesGroup { get; }

        Task<int> Complete();
    }
}