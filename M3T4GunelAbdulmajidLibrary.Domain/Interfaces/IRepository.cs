﻿using M3T4GunelAbdulmajidLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace M3T4GunelAbdulmajidLibrary.Domain.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        T GetById(int id);
        T Get(Expression<Func<T, bool>> predicate, bool asNoTracking = false, Func<IQueryable<T>,
            IIncludableQueryable<T, object>>? include = null);
        List<T> GetAll(Expression<Func<T, bool>>? predicate = null, bool asNoTracking = false,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
