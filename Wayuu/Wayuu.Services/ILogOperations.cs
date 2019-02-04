using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Entities;

namespace Wayuu.Services
{
    public interface ILogOperations
    {
        List<Log> GetAll();
    }
}
