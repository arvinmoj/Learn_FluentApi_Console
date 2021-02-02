using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class StudentAddress
    {
        public StudentAddress() : base()
        {

        }

        public int StudentAddressId { get; set; }

        public string Address { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}
