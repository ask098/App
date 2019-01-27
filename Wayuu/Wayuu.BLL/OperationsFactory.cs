using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Services;

namespace Wayuu.BLL
{
    public static class OperationsFactory
    {
        public static ISchoolOperations GetSchoolOperations()
        {
            return new SchoolOperations();
        }

        public static IWayuuLogOperations GetWayuuLogOperations()
        {
            return new WayuuLogOperations();
        }
    }
}
