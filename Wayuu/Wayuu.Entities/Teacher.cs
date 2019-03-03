using System;
using System.Collections.Generic;
using System.Text;

namespace Wayuu.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        public string Identification { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public int SchoolId { get; set; }
        public List<Course> Courses { get; set; }
    }
}
