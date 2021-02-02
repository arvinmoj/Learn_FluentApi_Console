using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class StudentCourse
    {
        public StudentCourse() : base()
        {

        }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public Models.Course Course { get; set; }

        public Models.Student Student { get; set; }
    }
}
