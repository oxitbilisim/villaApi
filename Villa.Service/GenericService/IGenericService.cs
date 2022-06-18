using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Villa.Service.GenericService;

public  interface IGenericService<T> where T:class
{
    Task<IQueryable<T>> GetAllAsync();
    Task<IQueryable<T>> FindByAsync(Expression<Func<T, bool>> predicate);
    Task<T> AddAsync(T entity);
    Task DeleteAsync(T entity);
    Task EditAsync(T entity);
}