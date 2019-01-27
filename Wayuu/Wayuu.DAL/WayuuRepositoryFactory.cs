using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Services;

namespace Wayuu.DAL
{
    public class WayuuRepositoryFactory
    {
        public static IWayuuRepository GetWayuuRepository(bool isUnitOfWork = false)
        {
            return new WayuuRepository(isUnitOfWork);
        }
    }
}
