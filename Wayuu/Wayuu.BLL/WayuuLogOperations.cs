using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.DAL;
using Wayuu.Entities;
using Wayuu.Services;

namespace Wayuu.BLL
{
    public class WayuuLogOperations : IWayuuLogOperations
    {
        public List<WayuuLog> GetAll()
        {
            return WayuuRepositoryFactory.GetWayuuRepository().GetLog();
        }
    }
}
