using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.DAL;
using Wayuu.Entities;
using Wayuu.Services;

namespace Wayuu.BLL
{
    public class LogOperations : ILogOperations
    {
        public List<Log> GetAll()
        {
            return WayuuRepositoryFactory
                .GetWayuuRepository()
                .GetAll<Log>();
        }
    }
}
