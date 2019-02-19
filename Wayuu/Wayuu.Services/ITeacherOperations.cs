using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Entities;

namespace Wayuu.Services
{
    public interface ITeacherOperations
    {
        Teacher Create(Teacher teacher);
        Teacher RetrieveById(int teacherId);
        bool Update(Teacher teacher);
        bool Delete(int teacherId);
        List<Teacher> GetAll();

        bool DeleteWithLog(int teacherId);
    }
}
