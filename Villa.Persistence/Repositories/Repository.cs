using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Villa.Domain;
using Villa.Domain.Entities;
using Villa.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task DeleteAsync(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
                _dbSet.Attach(entity);

            _dbSet.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            await DeleteAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
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

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            await _context.SaveChangesAsync();
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