using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Villa.Domain.Common;

namespace Villa.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<ResponseModel> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetAsync(int id);
    }
}