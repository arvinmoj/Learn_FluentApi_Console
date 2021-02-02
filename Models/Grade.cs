using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Grade
    {
        public Grade() : base()
        {

        }

        public int GradeId { get; set; }

        public string GradeName { get; set; }

        public List<Student> Students { get; set; }

    }
}
