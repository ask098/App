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
                    school = Repository.CreateSchool(school);
                }
            }
            else
            {
                school = null;
            }
            return school;
        }

        public bool Delete(int id)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
            {
                Result = Repository.DeleteSchool(id);
            }
            return Result;
        }

        public bool DeleteWithLog(int id)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository(true))
            {
                Repository.DeleteSchool(id);
                WayuuLog wayuuLog = new WayuuLog
                {
                    Type = LogType.DeleteSchool,
                    Message = $"ID: {id}"
                };
                Repository.CreateWayuuLog(wayuuLog);
                Result = Repository.SaveChanges() == 2;
            }
            return Result;
        }

        public List<School> GetAll()
        {
            return WayuuRepositoryFactory.GetWayuuRepository().GetSchools();
        }

        public School RetrieveSchoolById(int id)
        {
            School Result = null;
            if (id > 0)
            {
                using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
                {
                    Result = Repository.RetrieveSchoolById(id);
                }
            }
            return Result;
        }

        public bool Update(School school)
        {
            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
            {
                Result = Repository.UpdateSchool(school);
            }
            return Result;
        }
    }
}
