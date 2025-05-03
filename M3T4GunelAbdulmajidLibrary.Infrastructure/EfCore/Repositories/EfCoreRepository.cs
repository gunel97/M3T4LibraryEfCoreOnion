using M3T4GunelAbdulmajidLibrary.Domain.Entities;
using M3T4GunelAbdulmajidLibrary.Domain.Interfaces;
using M3T4GunelAbdulmajidLibrary.Infrastructure.EfCore.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace M3T4GunelAbdulmajidLibrary.Infrastructure.EfCore.Repositories
{
    public class EfCoreRepository<T> : IRepository<T> where T : Entity
    {
        private readonly AppDbContext _context;
        public EfCoreRepository()
        {
            _context = new AppDbContext();
        }


        public virtual T Add(T entity)
        {
            var added = _context.Set<T>().Add(entity);
            _context.SaveChanges();

            return added.Entity;
        }

        public virtual T Delete(T entity)
        {
            var deleted = _context.Set<T>().Remove(entity);
            _context.SaveChanges();

            return deleted.Entity;
        }

        public virtual T Get(Expression<Func<T, bool>> predicate, bool asNoTracking = false, Func<IQueryable<T>,
            IIncludableQueryable<T, object>>? include = null)
        {
            IQueryable<T> query = _context.Set<T>();

            query = query.Where(predicate);

            if (!asNoTracking)
                query = query.AsNoTracking();

            if (include != null)
                query = include.Invoke(query);

            return query.FirstOrDefault() ??
                throw new InvalidOperationException("Entity not found");
        }

        public virtual T GetById(int id)
        {
            return _context.Set<T>().AsNoTracking().SingleOrDefault(x => x.Id == id) ??
                throw new InvalidOperationException("Entity not found");
        }

        public virtual T Update(T entity)
        {
            var updated = _context.Set<T>().Update(entity);
            _context.SaveChanges();

            return updated.Entity;
        }

        public virtual List<T> GetAll(Expression<Func<T, bool>>? predicate, bool asNoTracking, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy)
        {
            IQueryable<T> query = _context.Set<T>();

            if (predicate != null)
                query = query.Where(predicate);

            if (include != null)
                query = include.Invoke(query);

            if (orderBy != null)
                query = orderBy.Invoke(query);

            if (!asNoTracking)
                query = query.AsNoTracking();

            return query.ToList();
        }
    }
}
