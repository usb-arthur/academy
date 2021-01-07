using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ACADEMY.Infrastructure.Interfaces;
using ACADEMY.Infrastructure.SharedKernel;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Data.EF
{
    public class EFRepository<T, TK> : IRepository<T, TK>, IDisposable where T : DomainEntity<TK>
    {
        private readonly AcademyDbContext _context;

        public EFRepository(AcademyDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }


        public async Task<T> FindByIdAsync(TK id, params Expression<Func<T, object>>[] includeProperties)
        {
            var items = await FindAllAsync(includeProperties);
            return await items.FirstOrDefaultAsync(e => e.Id.Equals(id));
        }

        public async Task<T> FindSingleAsync(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includeProperties)
        {
            var items = await FindAllAsync(includeProperties);
            return await items.FirstOrDefaultAsync(predicate);
        }

        public Task<IQueryable<T>> FindAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            var items = _context.Set<T>() as IQueryable<T>;

            if (includeProperties == null) return Task.FromResult(items);

            items = includeProperties.Aggregate(items, (current, includeProperty) => current.Include(includeProperty));

            return Task.FromResult(items);
        }

        public async Task<IQueryable<T>> FindAllAsync(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includeProperties)
        {
            return (await FindAllAsync(includeProperties)).Where(predicate);
        }

        public async Task<T> AddAsync(T entity)
        {
            return (await _context.AddAsync(entity)).Entity;
        }

        public Task<T> UpdateAsync(T entity)
        {
            return Task.FromResult(_context.Set<T>().Update(entity).Entity);
        }

        public Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            return Task.FromResult(0);
        }

        public async Task RemoveAsync(TK id)
        {
            var entity = await FindByIdAsync(id);
            await RemoveAsync(entity);
        }

        public Task RemoveMultipleAsync(IList<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            return Task.FromResult(0);
        }
    }
}