using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Entities;


namespace Wayuu.Services
{  
    public interface IStudentOperations
    {
        Student Create(Student student);
        Student RetrieveById(int studentId);
        bool Update(Student studentData);
        bool Delete(int studentId);
        List<Student> GetAll();
        bool DeleteWithLog(int studentId);
    }
}
