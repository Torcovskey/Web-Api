using System;
using System.Collections.Generic;
using System.Linq;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private DbContext context;
        private bool disposed;
        public Repository (DbContext context)
        {
            this.context = context;
            this.disposed = false;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void DeleteById(int entityId)
        {
            T deleteEntity = context.Set<T>().Find(entityId);
            context.Set<T>().Remove(deleteEntity);
        }
        public void Delete (T deleteEntity)
        {
            context.Set<T>().Remove(deleteEntity);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IQueryable<T> Get()
        {
            return context.Set<T>().AsQueryable();
        }

        public T GetById(int entityId)
        {
            return context.Set<T>().Find(entityId);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
