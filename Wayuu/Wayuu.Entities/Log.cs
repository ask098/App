using System;
using System.Collections.Generic;
using System.Text;

namespace Wayuu.Entities
{
    public enum LogType
    {
        DeleteSchool,
        DeleteStudent
    }
    public class Log
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public LogType Type { get; set; }
        public string Message { get; set; }
    }
}
