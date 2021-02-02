using System.Collections.Generic;

namespace Models
{
    public class Course
    {
        public Course() : base()
        {

        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public List<Models.StudentCourse> StudentCourses { get; set; }
    }
}
