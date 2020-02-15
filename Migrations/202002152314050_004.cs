namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _004 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Years",
                c => new
                    {
                        YearId = c.Int(nullable: false, identity: true),
                        YearNumber = c.Int(nullable: false),
                        YearName = c.String(),
                    })
                .PrimaryKey(t => t.YearId);
            
            CreateTable(
                "dbo.YearStudents",
                c => new
                    {
                        Year_YearId = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Year_YearId, t.Student_Id })
                .ForeignKey("dbo.Years", t => t.Year_YearId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Year_YearId)
                .Index(t => t.Student_Id);
            
            AddColumn("dbo.Students", "YearId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.YearStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.YearStudents", "Year_YearId", "dbo.Years");
            DropIndex("dbo.YearStudents", new[] { "Student_Id" });
            DropIndex("dbo.YearStudents", new[] { "Year_YearId" });
            DropColumn("dbo.Students", "YearId");
            DropTable("dbo.YearStudents");
            DropTable("dbo.Years");
        }
    }
}
