using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student
    {
        public Student() : base()
        {

        }

        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public int GradeId { get; set; }

        public Grade Grade { get; set; }

        public StudentAddress Address { get; set; }

        public List<Models.StudentCourse> StudentCourses { get; set; }
    }
}
