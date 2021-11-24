using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraKawe.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public int Batch { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }

        public Student()
        {

        }
    }
}
