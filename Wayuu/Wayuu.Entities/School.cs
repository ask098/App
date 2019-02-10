using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Wayuu.Entities
{
    public class School
    {
        public School()
        {

        }
        public int Id { get; set; }
        [MaxLength(10)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public DateTime Creation_date { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
    }
}
