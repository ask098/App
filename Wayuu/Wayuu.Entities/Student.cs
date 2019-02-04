using System;
using System.Collections.Generic;
using System.Text;

namespace Wayuu.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public DateTime DateAdmission { get; set; }
        public int CourseId { get; set; }
        public int SchoolId { get; set; }
    }
}
