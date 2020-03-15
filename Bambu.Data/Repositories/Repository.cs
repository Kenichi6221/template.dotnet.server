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
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity Item)
        {
            await _context.AddAsync(Item);
        }

        public async Task AddAllAsync(IEnumerable<TEntity> Items)
        {
            await _context.AddRangeAsync(Items);
        }

        public async Task DeleteAsync(int id)
        {
            _context.Remove(await GetByIDAsync(id));
        }

        public async Task<List<TEntity>> GetAsync<T2>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, T2>> order)
        {
            return await _context.Set<TEntity>().AsNoTracking().Where(predicate).OrderBy(order).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByIDAsync(int Id)
        {
            return await _context.Set<TEntity>().FindAsync(Id);
        }

        public void Update(TEntity Item)
        {
            _context.Update(Item);
        }

        public void UpdateRange(IEnumerable<TEntity> Items)
        {
            _context.UpdateRange(Items);
        }
    }
}