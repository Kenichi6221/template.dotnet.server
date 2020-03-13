using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Bambu.Core.Models;

namespace Bambu.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task Save(TEntity Item);
        Task Add(TEntity Item);
        Task SaveAll(IEnumerable<TEntity> Items);
        Task AddAll(IEnumerable<TEntity> Items);
        Task Delete(int PrimaryKey);
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        IEnumerable<TEntity> Find<T2>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, T2>> order);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}