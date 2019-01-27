using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Entities;

namespace Wayuu.Services
{
    public interface ISchoolOperations
    {
        School Create(School school);
        School RetrieveSchoolById(int id);
        bool Update(School school);
        bool Delete(int id);
        List<School> GetAll();

        bool DeleteWithLog(int id);
    }
}
