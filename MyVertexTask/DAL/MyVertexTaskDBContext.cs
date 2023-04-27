using MyVertexTask.Domain.Models;
using System.Data.Entity;

namespace MyVertexTask.DAL
{
    public class MyVertexTaskDBContext : DbContext
    {
        public MyVertexTaskDBContext() : base("MyVertexTask") { }

        public DbSet<CollegeSport> CollegeSportsEngagedIn { get; set; }
        public DbSet<HighSchool> HighSchools { get; set; }
        public DbSet<PostHighSchoolExp> PostHighSchoolsExps { get; set; }
        public DbSet<SERForm1Side1> SERForm1Side1s { get; set; }
    }
}