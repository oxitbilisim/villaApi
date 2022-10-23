
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Query;
using Villa.Persistence;

namespace Villa.Service.Base
{

    public class BaseService<T> where T : class
    {
        private appDbContext _appDbContext;
        private IMapper _mapper;

        public BaseService(
            appDbContext appDbContext,
            IMapper mapper
        )
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public virtual IQueryable<T> Entity() =>
            _appDbContext
            .Set<T>();

        public virtual IQueryable<M> GetAll<M>(Expression<Func<T, bool>> predicate) =>
            _appDbContext
            .Set<T>()
            .Where(predicate)
            .ProjectTo<M>(_mapper.ConfigurationProvider);

        public virtual IQueryable<M> GetAll<M>() =>
            _appDbContext
            .Set<T>()
            .ProjectTo<M>(_mapper.ConfigurationProvider);
        public virtual IQueryable<T> GetAll() =>
            _appDbContext
          .Set<T>();
        
        public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> predicate) =>
            _appDbContext
         .Set<T>()
         .Where(predicate);
        
        public virtual IQueryable<M> GetAllPI<M>(Expression<Func<T, bool>> predicate = null,
                                                         Func<IQueryable<T>,IIncludableQueryable<T, object>> include = null) 
        {
            IQueryable<T> query = _appDbContext.Set<T>();
   
            
            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return query.ProjectTo<M>(_mapper.ConfigurationProvider);;
        }
        public virtual M Get<M>(int Id) =>
            _mapper
            .Map<M>(_appDbContext
            .Set<T>()
            .Find(Id));

        public virtual T Get(int Id) =>
            _appDbContext
           .Set<T>()
           .Find(Id);
        
        public virtual IQueryable<M> GetPI<M>(Expression<Func<T, bool>> predicate  = null,
                                              Func<IQueryable<T>,IIncludableQueryable<T, object>> include = null) 
        {
            IQueryable<T> query = _appDbContext.Set<T>();
            IOrderedQueryable<T> orderBy = null;

            if (include != null)
            {
                query = include(query);
            }
            
            
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            // PropertyInfo propertyInfo = query.GetType().GetProperty("IsDeleted");
            // propertyInfo.SetValue(query, Convert.ChangeType(true, propertyInfo.PropertyType), null);

            return query.ProjectTo<M>(_mapper.ConfigurationProvider);
        }
        
        public virtual int Add<M>(M model)
        {
            var data = _mapper.Map<T>(model);
              
            _appDbContext
                .Set<T>()
                .Add(data);
            _appDbContext.SaveChanges();

            return Convert.ToInt32(data.GetType().GetProperty("Id").GetValue(data).ToString());
        }
        public virtual int AddMany<M>(List<M> model)
        {
            _appDbContext
                .Set<T>()
                .AddRange(_mapper.Map<List<T>>(model));

            return _appDbContext.SaveChanges();
        }
        public virtual int Update<M>(M model)
        {
            var data = _mapper.Map<T>(model);
            _appDbContext
                .Entry<T>(data)
                .State = EntityState.Modified;
            _appDbContext.SaveChanges();
            return Convert.ToInt32(data.GetType().GetProperty("Id").GetValue(data).ToString()); ;
        }
        public virtual bool Exist(int Id)
        {
            return _appDbContext.Set<T>().Any();
        }
        public virtual int Delete(int Id)
        {
            var data = _appDbContext.Set<T>().Find(Id);
            
            PropertyInfo propertyInfo = data.GetType().GetProperty("IsDeleted");
            propertyInfo.SetValue(data, Convert.ChangeType(true, propertyInfo.PropertyType), null);
            
            _appDbContext
                .Entry<T>(data)
                .State = EntityState.Modified;
            _appDbContext.SaveChanges();
            // _appDbContext
            //     .Set<T>()
            //     .Remove(data);
            return _appDbContext.SaveChanges();
        }

        public virtual int Pasif(int Id)
        {
            var data = _appDbContext.Set<T>().Find(Id);

            PropertyInfo propertyInfo = data.GetType().GetProperty("Active");
            propertyInfo.SetValue(data, Convert.ChangeType(false, propertyInfo.PropertyType), null);

            _appDbContext
                .Entry<T>(data)
                .State = EntityState.Modified;
            _appDbContext.SaveChanges();
            // _appDbContext
            //     .Set<T>()
            //     .Remove(data);
            return _appDbContext.SaveChanges();
        }

        public virtual int Active(int Id)
        {
            var data = _appDbContext.Set<T>().Find(Id);

            PropertyInfo propertyInfo = data.GetType().GetProperty("Active");
            propertyInfo.SetValue(data, Convert.ChangeType(true, propertyInfo.PropertyType), null);

            _appDbContext
                .Entry<T>(data)
                .State = EntityState.Modified;
            _appDbContext.SaveChanges();
            // _appDbContext
            //     .Set<T>()
            //     .Remove(data);
            return _appDbContext.SaveChanges();
        }

        public virtual int DeleteHard(int Id)
        {
            var data = _appDbContext.Set<T>().Find(Id); 
            _appDbContext
            .Set<T>()
            .Remove(data);
        
        
            return _appDbContext.SaveChanges();
        }
    }
}
