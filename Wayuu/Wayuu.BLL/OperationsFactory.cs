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

<<<<<<< HEAD
        public static ITeacherOperations GetTeacherOperations()
        {
            return new TeacherOperations();
        }
=======
        public static ICourseOperations GetCourseOperations()
        {
            return new CourseOperations();
        }
       
>>>>>>> origin/Course
    }
}
