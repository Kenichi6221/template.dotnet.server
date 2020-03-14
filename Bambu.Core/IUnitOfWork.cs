using System;
using System.Threading.Tasks;
using Bambu.Core.Repositories;

namespace Bambu.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ISalesPersonRepository SalesPerson { get; }

        Task<int> Complete();
    }
}