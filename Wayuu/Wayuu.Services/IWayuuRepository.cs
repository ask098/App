using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Entities;

namespace Wayuu.Services
{
    public interface IWayuuRepository : IDisposable
    {
        School CreateSchool(School school);
        School RetrieveSchoolById(int schoolId);
        bool UpdateSchool(School school);
        bool DeleteSchool(int schoolId);
        List<School> GetSchools();


        List<Log> GetLog();
        Log CreateWayuuLog(Log wayuuLog);

        int SaveChanges();
    }
}
