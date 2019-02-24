using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.DAL;
using Wayuu.Entities;
using Wayuu.Services;

namespace Wayuu.BLL
{
    public class StudentOperations : IStudentOperations
    {
        public Student Create(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.Name))
            {
                using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
                {
                    student = Repository.Create(student);
                }
            }
            else
            {
                student = null;
            }
            return student;
        }

        public bool Delete(int studentId)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
            {
                Result = Repository.Delete(new School { Id = studentId });
            }
            return Result;
        }

        public bool DeleteWithLog(int studentId)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository(true))
            {
                Repository.Delete(new School { Id = studentId });
                Log Log = new Log
                {
                    Type = LogType.DeleteSchool,
                    Message = $"ID: {studentId}"
                };

                Repository.Create(Log);
                Result = Repository.SaveChanges() == 2;
            }
            return Result;
        }

        public List<Student> GetAll()
        {
            return WayuuRepositoryFactory
                           .GetWayuuRepository()
                           .GetAll<Student>();
        }

        public Student RetrieveById(int studentId)
        {
            Student Result = null;
            if (studentId > 0)
            {
                using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
                {
                    Result = Repository.RetrieveById<Student>(studentId);
                }
            }
            return Result;
        }

        public bool Update(Student studentData)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
            {
                Result = Repository.Update(studentData);
            }
            return Result;
        }
    }
}
