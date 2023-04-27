namespace MyVertexTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CollegeSports",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Sports = c.String(),
                        College = c.String(),
                        VrsityJVOrClub = c.String(),
                        Semester = c.String(),
                        Year = c.String(),
                        SERForm1Side1_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SERForm1Side1", t => t.SERForm1Side1_Id)
                .Index(t => t.SERForm1Side1_Id);
            
            CreateTable(
                "dbo.HighSchools",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        DateLastAttended = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PostHighSchoolExps",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CollegesAttendedOrJobsHeld = c.String(),
                        From = c.String(),
                        To = c.String(),
                        SERForm1Side1_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SERForm1Side1", t => t.SERForm1Side1_Id)
                .Index(t => t.SERForm1Side1_Id);
            
            CreateTable(
                "dbo.SERForm1Side1",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        PresentCollege = c.String(nullable: false),
                        PresentConference = c.String(nullable: false),
                        Sports = c.String(nullable: false),
                        PreviousSeasons = c.Int(nullable: false),
                        StudentID = c.String(nullable: false),
                        Telephone = c.String(nullable: false),
                        PresentAddress = c.String(nullable: false),
                        DateofFilled = c.String(nullable: false),
                        DateOfBirth = c.String(nullable: false),
                        HighSchoolID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HighSchools", t => t.HighSchoolID, cascadeDelete: true)
                .Index(t => t.HighSchoolID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostHighSchoolExps", "SERForm1Side1_Id", "dbo.SERForm1Side1");
            DropForeignKey("dbo.SERForm1Side1", "HighSchoolID", "dbo.HighSchools");
            DropForeignKey("dbo.CollegeSports", "SERForm1Side1_Id", "dbo.SERForm1Side1");
            DropIndex("dbo.SERForm1Side1", new[] { "HighSchoolID" });
            DropIndex("dbo.PostHighSchoolExps", new[] { "SERForm1Side1_Id" });
            DropIndex("dbo.CollegeSports", new[] { "SERForm1Side1_Id" });
            DropTable("dbo.SERForm1Side1");
            DropTable("dbo.PostHighSchoolExps");
            DropTable("dbo.HighSchools");
            DropTable("dbo.CollegeSports");
        }
    }
}
