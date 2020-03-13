using System.Threading.Tasks;
using Bambu.Core.Models;
using Bambu.Core.Repositories;

namespace Bambu.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        public Task Add(TEntity Item)
        {
            throw new System.NotImplementedException();
        }

        public Task AddAll(System.Collections.Generic.IEnumerable<TEntity> Items)
        {
            throw new System.NotImplementedException();
        }

        public Task AddAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task AddRangeAsync(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int PrimaryKey)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<TEntity> Find<T2>(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate, System.Linq.Expressions.Expression<System.Func<TEntity, T2>> order)
        {
            throw new System.NotImplementedException();
        }

        public Task<System.Collections.Generic.IEnumerable<TEntity>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            throw new System.NotImplementedException();
        }

        public Task Save(TEntity Item)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveAll(System.Collections.Generic.IEnumerable<TEntity> Items)
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> SingleOrDefaultAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }
    }
}