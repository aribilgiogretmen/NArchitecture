﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace NArchitecture.Core.Repositories
{
    public interface IRepository<T>where T: class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T>Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}
