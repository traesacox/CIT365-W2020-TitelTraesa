using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; } //Primary Key
        public int CourseID { get; set; }//Foreign Key - navigation property 1-1 relationship
        public int StudentID { get; set; }//Foreign Key - navigation property 1-1 relationship
        public Grade? Grade { get; set; }// ? means nullable enum

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
