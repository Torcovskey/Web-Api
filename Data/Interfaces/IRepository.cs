﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IRepository<T> : IDisposable
    {
        IQueryable<T> Get();
        T GetById(int entityId);
        void Add(T entity);
        void DeleteById(int entityId);
        void Delete(T entity);
        void Update(T entity);
    }
}
