using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Bambu.Core.Models;
using Bambu.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bambu.Data.Repositories
{
    public class TrackingRepository<TEntity> : ITrackingRepository<TEntity> where TEntity : TrackedEntity
    {
        protected readonly DbContext _context;

        public TrackingRepository(DbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdateDate = DateTime.Now;
            await _context.Set<TEntity>().AddAsync(entity);
        }
        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIDAsync(id);
            entity.LastUpdateDate = DateTime.Now;
            entity.Deleted = true;
        }

        public async Task<List<TEntity>> GetAsync<T2>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, T2>> order)
        {
            var responseCollection = await _context.Set<TEntity>().Where(predicate).OrderBy(order).ToListAsync();
            var actives = responseCollection.Where(e => !e.Deleted).ToList();

            return actives;
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().Where(e => !e.Deleted).ToListAsync();
        }

        public async Task<TEntity> GetByIDAsync(int Id)
        {
            return await _context.Set<TEntity>().FindAsync(Id);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().SingleOrDefaultAsync(predicate);
        }

        public virtual void Update(TEntity Item)
        {
            Item.LastUpdateDate = DateTime.Now;
            _context.Update(Item);
        }

        public virtual void UpdateRange(IEnumerable<TEntity> Items)
        {
            _context.UpdateRange(Items);
        }
    }
}