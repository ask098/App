using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.DAL;
using Wayuu.Entities;
using Wayuu.Services;

namespace Wayuu.BLL
{
    public class TeacherOperations : ITeacherOperations
    {
        public Teacher Create(Teacher teacher)
        {
            if (!string.IsNullOrWhiteSpace(teacher.Name))
            {
                using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
                {
                    teacher = Repository.Create(teacher);
                }
            }
            else
            {
                teacher = null;
            }
            return teacher;
        }

        public Teacher RetrieveById(int id)
        {
            Teacher Result = null;
            if (id > 0)
            {
                using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
                {
                    Result = Repository.RetrieveById<Teacher>(id);
                }
            }
            return Result;
        }

        public bool Update(Teacher teacher)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
            {
                Result = Repository.Update(teacher);
            }
            return Result;
        }

        public bool Delete(int id)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
            {
                Result = Repository.Delete(new Teacher { Id = id });
            }
            return Result;
        }

        public bool DeleteWithLog(int id)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository(true))
            {
                Repository.Delete(new Teacher { Id = id });
                Log Log = new Log
                {
                    Type = LogType.DeleteTeacher,
                    Message = $"ID: {id}"
                };

                Repository.Create(Log);
                Result = Repository.SaveChanges() == 2;
            }
            return Result;
        }

        public List<Teacher> GetAll()
        {
            return WayuuRepositoryFactory
                .GetWayuuRepository()
                .GetAll<Teacher>();
        }
    }
}
