using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Application
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string Department { get; set; }
        public double GPA { get; set; }
        public string GradStudentStatus { get; set; }
        public int SemesterAtU { get; set; }
        public int SemesterRemainingAtU { get; set; }
        public string CoursesInterestedForTA { get; set; }
        public string GradeReceivedInInteresedCourse { get; set; }
        public string PersonalStatement { get; set; }
        public string Skills { get; set; }
        public string PersonalProjects { get; set; }
    }
}
