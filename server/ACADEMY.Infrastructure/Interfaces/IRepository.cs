using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ACADEMY.Infrastructure.Interfaces
{
    public interface IRepository<T, TK> where T : class
    {
        Task<T> FindByIdAsync(TK id, params Expression<Func<T, object>>[] includeProperties);

        Task<T> FindSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        Task<IQueryable<T>> FindAllAsync(params Expression<Func<T, object>>[] includeProperties);

        Task<IQueryable<T>> FindAllAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task RemoveAsync(T entity);

        Task RemoveAsync(TK id);

        Task RemoveMultipleAsync(IList<T> entities);
    }
}
