using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Entities;

namespace Wayuu.Services
{
    public interface ISchoolOperations
    {
        School Create(School school);
        School RetrieveById(int schoolId);
        bool Update(School school);
        bool Delete(int schoolId);
        List<School> GetAll();

        bool DeleteWithLog(int schoolId);
    }
}
