using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Villa.Domain;
using Villa.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Villa.Domain.Common;

namespace Villa.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseSimpleModel
    {
        private readonly appDbContext _context;
        private DbSet<T> _dbSet;

        public Repository(appDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        
        public async Task<ResponseModel> AddAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await _context.AddAsync(entity);
                var result = await _context.SaveChangesAsync();
                return new ResponseModel(){ Success = true, Message = "Succeded",Data = entity.Id};
            }
            catch (Exception ex)
            {
                return new ResponseModel(){ Success = false, Message = "Error",Data = ex.InnerException.Message};
                //throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }
        public async Task<ResponseModel> DeleteAsync(T entity)
        {
            try
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                    _dbSet.Attach(entity);

                //_dbSet.Remove(entity);
                entity.IsDeleted = true;
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return new ResponseModel(){ Success = true, Message = "Succeded",Data = entity.Id};
            }
            catch (Exception ex)
            {
                return new ResponseModel(){ Success = false, Message = "Error",Data = ex.InnerException.Message};
            }
        }

        public async Task<ResponseModel> DeleteAsync(int id)
        {
            try
            {
                var entity = await GetAsync(id);
                await DeleteAsync(entity);
                await _context.SaveChangesAsync();
                
                return new ResponseModel(){ Success = true, Message = "Succeded",Data = entity.Id};
            }
            catch (Exception e)
            {
                return new ResponseModel(){ Success = false, Message = "Error",Data = e.InnerException.Message};
            }
        }

        public Task<IQueryable<T>> GetAllAsync()
        {
            return this.GetAllAsync(null, null, null, null, null);
        }

        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return this.GetAllAsync(predicate, null, null, null, null);
        }

        public Task<IQueryable<T>> GetAllAsync(Func<IQueryable<T>, IIncludableQueryable<T, object>> include)
        {
            return this.GetAllAsync(null, include, null, null, null);
        }
      public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
                                                 Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                                 Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                 int? skip = null, int? take = null)
        {
            IQueryable<T> query = GetQueryable(predicate, include);
            
            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (skip != null && skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }

            if (take != null && take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return new Task<IQueryable<T>>(() => query);
        }

        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
                                                Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return new Task<IQueryable<T>> (() => GetQueryable(predicate, include)); 
        }

        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        string orderBy = null, string orderDirection = "asc",
         int? skip = null, int? take = null)
        {
            IQueryable<T> query = GetQueryable(predicate, include);

            if (orderBy != null)
            {
                //query = query.OrderBy(orderBy, orderDirection);
            }

            if (skip != null && skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }

            if (take != null && take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return new Task<IQueryable<T>>(() => query);
        }

        /// <summary>
        /// Returns a single instance of T but throws exception if none is found
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public T GetSingle(
         Expression<Func<T, bool>> predicate = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = GetQueryable(predicate, include);
        
            return query.FirstOrDefault();
        }

        public Task<T> GetSingleAsync(
          Expression<Func<T, bool>> predicate = null,
          Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            // predicate =  model => model.IsDeleted == false; 
            IQueryable<T> query = GetQueryable(predicate, include);
                
            return query.FirstOrDefaultAsync();
        }
        private IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _context.Set<T>();
            
            if (include != null)
            {
                query = include(query);
            }

            //
            if (predicate != null)
            {
                query = query.Where(predicate); 
            }

            return query;
        }

        public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            return entity;
        }

        public async Task<ResponseModel> UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;

                await _context.SaveChangesAsync();
                return new ResponseModel(){ Success = true, Message = "Succeded",Data = entity.Id};
            }
            catch (Exception ex)
            {
                return new ResponseModel(){ Success = false, Message = "Error",Data = ex.InnerException.Message};
                //throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }
        
        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}