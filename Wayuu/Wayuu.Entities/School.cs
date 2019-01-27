using System;
using System.Collections.Generic;
using System.Text;

namespace Wayuu.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
    }
}
