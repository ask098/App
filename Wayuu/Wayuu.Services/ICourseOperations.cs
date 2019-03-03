using System;
using System.Collections.Generic;
using Wayuu.Entities;
using System.Text;

namespace Wayuu.Services
{
    public interface ICourseOperations
    {
        Course Create(Course course);
        Course RetrieveById(int courseId);
        bool Update(Course course);
        bool Delete(int courseId);
        List<Course> GetAll();
        bool DeleteWithLog(int courseId);        
    }
}
