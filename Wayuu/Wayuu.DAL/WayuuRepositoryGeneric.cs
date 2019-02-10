using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Wayuu.DAL
{
    public class WayuuRepositoryGeneric : IDisposable
    {
        DbContext WayuuContext;
        readonly bool IsUnitOfWork;

        public WayuuRepositoryGeneric(DbContext context ,bool isUnitOfWork = false)
        {
            this.WayuuContext = new WayuuContext();
            this.IsUnitOfWork = isUnitOfWork;
        }

        public virtual T Create<T>(T entity) where T: class
        {
            T NewEntity = WayuuContext.Add(entity).Entity;
            Save();
            return NewEntity;
        }

        public virtual T RetrieveById<T>(params object[] keyValues) where T: class
        {
            return WayuuContext.Find<T>(keyValues);
        }

        public virtual bool Update<T>(T entity)where T:class
        {
            WayuuContext.Update(entity);
            return Save();
        }

        public virtual bool Delete<T>(T entity)where T:class
        {
            WayuuContext.Remove(entity);
            return Save();
        }

        public virtual List<T> GetAll<T>()where T:class
        {
            return WayuuContext.Set<T>().ToList();
        }

        public virtual int SaveChanges()
        {
            var Result = 0;
            if (WayuuContext != null)
            {
                try
                {
                    Result = WayuuContext.SaveChanges();
                }
                catch (Exception e)
                {

                    HandleException(e);
                    Result = 0;
                }
            }
            return Result;
        }

        public virtual void HandleException(Exception e)
        {
            Debug.WriteLine("Error: " + e);
        }

        public void Dispose()
        {
            WayuuContext.Dispose();
        }

        private bool Save()
        {
            var Changes = 0;
            if (!IsUnitOfWork)
            {
                Changes = SaveChanges();
            }
            return Changes == 1;
        }
    }
}
