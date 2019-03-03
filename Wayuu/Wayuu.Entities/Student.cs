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
        public int Birthdate { get; set; }
        public Int64 Cid { get; set; }
        public string TipeCid { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Municipality { get; set; }
        public int CourseId { get; set; }
        public int SchoolId { get; set; }
    }
}
