using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Bambu.Core.Models;

namespace Bambu.Core.Repositories
{
    public interface ITrackingRepository<TEntity> where TEntity : TrackedEntity
    {
        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> GetByIDAsync(int Id);

        Task<List<TEntity>> GetAsync<T2>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, T2>> order);

        Task AddAsync(TEntity Item);

        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task DeleteAsync(int PrimaryKey);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        void Update(TEntity Item);

        void UpdateRange(IEnumerable<TEntity> Items);
    }
}