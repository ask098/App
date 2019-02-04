using System;
using System.Collections.Generic;
using System.Text;

namespace Wayuu.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime Schedule { get; set; }
        public string Place { get; set; }
        public int TeacherId { get; set; }
        public List<Student> Students { get; set; }
    }
}
