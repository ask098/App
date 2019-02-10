using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Entities;

namespace Wayuu.Services
{
    public interface IWayuuRepository : IDisposable
    {
        T Create<T>(T entoty)where T: class;
        T RetrieveById<T>(params object[] keyValues) where T:class;
        bool Update<T>(T entity)where T:class;
        bool Delete<T>(T entity)where T:class;
        List<T> GetAll<T>() where T:class;


        int SaveChanges();
    }
}
