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

        public static ILogOperations GetWayuuLogOperations()
        {
            return new LogOperations();
        }
        public static IStudentOperations GetStudentOperations()
        {
            return new StudentOperations();
        }
    }
}
