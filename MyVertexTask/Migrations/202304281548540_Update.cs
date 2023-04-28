namespace MyVertexTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SERForm1Side1", "HighSchoolID", "dbo.HighSchools");
            DropIndex("dbo.SERForm1Side1", new[] { "HighSchoolID" });
            AlterColumn("dbo.SERForm1Side1", "HighSchoolID", c => c.String(maxLength: 128));
            CreateIndex("dbo.SERForm1Side1", "HighSchoolID");
            AddForeignKey("dbo.SERForm1Side1", "HighSchoolID", "dbo.HighSchools", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SERForm1Side1", "HighSchoolID", "dbo.HighSchools");
            DropIndex("dbo.SERForm1Side1", new[] { "HighSchoolID" });
            AlterColumn("dbo.SERForm1Side1", "HighSchoolID", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.SERForm1Side1", "HighSchoolID");
            AddForeignKey("dbo.SERForm1Side1", "HighSchoolID", "dbo.HighSchools", "Id", cascadeDelete: true);
        }
    }
}
