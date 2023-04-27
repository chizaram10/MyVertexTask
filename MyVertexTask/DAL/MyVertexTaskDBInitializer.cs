using MyVertexTask.Domain.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace MyVertexTask.DAL
{
    public class MyVertexTaskDBInitializer : DropCreateDatabaseIfModelChanges<MyVertexTaskDBContext>
    {
        protected override void Seed(MyVertexTaskDBContext context)
        {
            GetSERForm1Side1s().ForEach(f  => context.SERForm1Side1s.Add(f));
        }
        private static List<SERForm1Side1> GetSERForm1Side1s()
        {
            var forms = new List<SERForm1Side1>()
            {
                new SERForm1Side1
                {
                    Name = "John Doe",
                    Gender = "Male",
                    DateOfBirth = "04/27/94",
                    DateofFilled = "04/27/23",
                    PresentCollege = "Louisiana State University",
                    PresentConference = "Southeastern",
                    Sports = "Football",
                    Telephone = "(555) 555-1234",
                    PresentAddress = "Address",
                    PreviousSeasons = 0,
                    StudentID = "ADCVH/21234",
                    HighSchool = new HighSchool
                    {
                        Name = "Thomas Jefferson High School for Science and Technology. Alexandria, VA",
                        DateLastAttended = "03/27/23"
                    },
                    PostHighSchoolExps = new List<PostHighSchoolExp>()
                    {
                        new PostHighSchoolExp
                        {
                            CollegesAttendedOrJobsHeld = "None"
                        }
                    },
                    CollegeSports = new List<CollegeSport>
                    {
                        new CollegeSport
                        {
                            College = "None"
                        }
                    }
                }
            };
            return forms;
        }
    }
}