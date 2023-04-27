namespace MyVertexTask.Migrations
{
    using MyVertexTask.Domain.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyVertexTask.DAL.MyVertexTaskDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyVertexTask.DAL.MyVertexTaskDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            GetSERForm1Side1s().ForEach(f => context.SERForm1Side1s.Add(f));
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
