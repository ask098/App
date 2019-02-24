using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.DAL;
using Wayuu.Entities;
using Wayuu.Services;

namespace Wayuu.BLL
{
    public class CourseOperations : ICourseOperations
    {
        public Course Create(Course course)
        {

            if (!string.IsNullOrWhiteSpace(course.Name))
            {
                using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
                {
                    course = Repository.Create(course);
                }
            }
            else
            {
                course = null;
            }
            return course;

        }

        public bool Delete(int courseId)
        {

            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
            {
                Result = Repository.Delete(new School { Id = courseId });
            }
            return Result;

        }

        public bool DeleteWithLog(int courseId)
        {

            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository(true))
            {
                Repository.Delete(new School { Id = courseId });
                Log Log = new Log
                {
                    Type = LogType.DeleteSchool,
                    Message = $"ID: {courseId}"
                };

                Repository.Create(Log);
                Result = Repository.SaveChanges() == 2;
            }
            return Result;

        }

        public List<Course> GetAll()
        {
            return WayuuRepositoryFactory
                .GetWayuuRepository()
                .GetAll<Course>();
        }

        public Course RetrieveById(int courseId)
        {

            Course Result = null;
            if (courseId > 0)
            {
                using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
                {
                    Result = Repository.RetrieveById<Course>(courseId);
                }
            }
            return Result;

        }

        public bool Update(Course course)
        {

            bool Result = false;
            using (var Repository = WayuuRepositoryFactory.GetWayuuRepository())
            {
                Result = Repository.Update(course);
            }
            return Result;

        }
    }
}
