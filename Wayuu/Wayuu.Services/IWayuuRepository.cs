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


        List<WayuuLog> GetLog();
        WayuuLog CreateWayuuLog(WayuuLog wayuuLog);

        int SaveChanges();
    }
}
