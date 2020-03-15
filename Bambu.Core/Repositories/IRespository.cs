using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Bambu.Core.Models;

namespace Bambu.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIDAsync(int Id);
        Task<List<TEntity>> GetAsync<T2>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, T2>> order);

        void Update(TEntity Item);
        Task AddAsync(TEntity Item);
        void UpdateRange(IEnumerable<TEntity> Items);
        Task AddAllAsync(IEnumerable<TEntity> Items);

        Task DeleteAsync(int PrimaryKey);
    }
}