using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.DAL;
using Wayuu.Entities;
using Wayuu.Services;

namespace Wayuu.BLL
{
    public class SchoolOperations : ISchoolOperations
    {
        public School Create(School school)
        {
            if (!string.IsNullOrWhiteSpace(school.Name))
            {
                using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
                {
                    school = Repository.Create(school);
                }
            }
            else
            {
                school = null;
            }
            return school;
        }

        public School RetrieveById(int id)
        {
            School Result = null;
            if (id > 0)
            {
                using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
                {
                    Result = Repository.RetrieveById<School>(id);
                }
            }
            return Result;
        }

        public bool Update(School school)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
            {
                Result = Repository.Update(school);
            }
            return Result;
        }

        public bool Delete(int id)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
            {
                Result = Repository.Delete(new School { Id = id});
            }
            return Result;
        }

        public bool DeleteWithLog(int id)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository(true))
            {
                Repository.Delete(new School { Id = id});
                Log Log = new Log
                {
                    Type = LogType.DeleteSchool,
                    Message = $"ID: {id}"
                };

                Repository.Create(Log);
                Result = Repository.SaveChanges() == 2;
            }
            return Result;
        }

        public List<School> GetAll()
        {
            return WayuuRepositoryFactory
                .GetWayuuRepository()
                .GetAll<School>();
        }
    }
}
