using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DBInitializer
    {
        public static void Initialize(TA_DB context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Applications.Any())
            {
                return;   // DB has been seeded
            }

            var applications = new Application[]
            {
                new Application{Name="Cosmo Kramer", Email="cosmo@email.com", PhoneNum="801-123-4567", Department="School of Computing", GPA=4.0, GradStudentStatus="Undergraduate",
                    SemesterAtU=6, SemesterRemainingAtU=2, CoursesInterestedForTA="CS 1400, CS 2420", GradeReceivedInInteresedCourse="CS 1400 - A, CS 2420 - A", 
                    PersonalStatement="I will be a good TA.", PersonalProjects="Kramerica"},
                new Application{Name="George Costanza", Email="cantstandya@email.com", PhoneNum="801-123-4567", Department="School of Computing", GPA=3.44, GradStudentStatus="Undergraduate",
                    SemesterAtU=8, SemesterRemainingAtU=3, CoursesInterestedForTA="CS 1400, CS 2420", GradeReceivedInInteresedCourse="CS 1400 - B, CS 2420 - B-",
                    PersonalStatement="I will be a good TA.", PersonalProjects="Sandstorm"},
                new Application{Name="Elaine Benes", Email="elaine@email.com", PhoneNum="801-123-4567", Department="School of Computing", GPA=3.8, GradStudentStatus="Undergraduate",
                    SemesterAtU=5, SemesterRemainingAtU=2, CoursesInterestedForTA="CS 1400", GradeReceivedInInteresedCourse="CS 1400 - A",
                    PersonalStatement="I will be a good TA.", PersonalProjects="Pendant"},
                new Application{Name="Jerry Seinfeld", Email="jerry@email.com", PhoneNum="801-123-4567", Department="School of Computing", GPA=3.75, GradStudentStatus="Undergraduate",
                    SemesterAtU=8, SemesterRemainingAtU=3, CoursesInterestedForTA="CS 3500, CS 3505", GradeReceivedInInteresedCourse="CS 3500 - B, CS 3505 - A-",
                    PersonalStatement="I will be a good TA.", PersonalProjects="Seinfeld"},
                new Application{Name="Soup Nazi", Email="soupnazi@email.com", PhoneNum="801-123-4567", Department="School of Computing", GPA=3.9, GradStudentStatus="Graduate",
                    SemesterAtU=8, SemesterRemainingAtU=3, CoursesInterestedForTA="CS 4150", GradeReceivedInInteresedCourse="CS 4150 - A",
                    PersonalStatement="I will be a good TA.", PersonalProjects="Armoire"}

            };
            foreach (Application a in applications)
            {
                context.Applications.Add(a);
            }
            context.SaveChanges();            
        }
    }
}
