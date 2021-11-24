using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraKawe.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public List<StudentCourse> StudentCourses { get; set; }
        public Course()
        {

        }
    }
}
