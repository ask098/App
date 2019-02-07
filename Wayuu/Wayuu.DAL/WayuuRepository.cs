using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Entities;
using Wayuu.Services;
using System.Linq;
using System.Diagnostics;

namespace Wayuu.DAL
{
    public class WayuuRepository : IWayuuRepository, IDisposable
    {
        WayuuContext WayuuContext;
        bool IsUnitOfWork;

        public WayuuRepository(bool isUnitOfWork = false)
        {
            this.WayuuContext = new WayuuContext();
            this.IsUnitOfWork = isUnitOfWork;
        }

        public int SaveChanges()
        {
            var Result = 0;
            if (WayuuContext != null)
            {
                try
                {
                    Result = WayuuContext.SaveChanges();
                }
                catch(Exception e)
                {

                    Debug.WriteLine("Error: " + e);
                    Result = 0;
                }
            }
            return Result;
        }

        private bool Save()
        {
            var Changes = 0;
            if (!IsUnitOfWork)
            {
                Changes = SaveChanges();
            }
            return Changes == 1;
        }

        public School CreateSchool(School school)
        {
            school = WayuuContext.Add(school).Entity;
            Save();
            return school;
        }

        public School RetrieveSchoolById(int schoolId)
        {
            return WayuuContext.Find<School>(schoolId);
        }

        public bool UpdateSchool(School school)
        {
            WayuuContext.Update(school);
            return Save();
        }

        public bool DeleteSchool(int schoolId)
        {
            WayuuContext.Remove(new School { Id = schoolId });
            return Save();
        }

        public List<School> GetSchools()
        {
            return WayuuContext.Schools.ToList();
        }

        public Log CreateWayuuLog(Log wayuuLog)
        {
            wayuuLog = WayuuContext.Add(wayuuLog).Entity;
            Save();
            return wayuuLog;
        }

        public List<Log> GetLog()
        {
            return WayuuContext.Logs.ToList();
        }

        public void Dispose()
        {
            WayuuContext.Dispose();
        }
    }
}
