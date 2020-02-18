namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MU : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.YearStudents", "Year_YearId", "dbo.Years");
            DropForeignKey("dbo.YearStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Teachers", "TeacherId", "dbo.Years");
            DropIndex("dbo.YearStudents", new[] { "Year_YearId" });
            DropIndex("dbo.YearStudents", new[] { "Student_Id" });
            DropPrimaryKey("dbo.Years");
            AlterColumn("dbo.Years", "YearId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Years", "YearId");
            CreateIndex("dbo.Years", "YearId");
            AddForeignKey("dbo.Years", "YearId", "dbo.Students", "Id");
            AddForeignKey("dbo.Teachers", "TeacherId", "dbo.Years", "YearId");
            DropTable("dbo.YearStudents");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.YearStudents",
                c => new
                    {
                        Year_YearId = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Year_YearId, t.Student_Id });
            
            DropForeignKey("dbo.Teachers", "TeacherId", "dbo.Years");
            DropForeignKey("dbo.Years", "YearId", "dbo.Students");
            DropIndex("dbo.Years", new[] { "YearId" });
            DropPrimaryKey("dbo.Years");
            AlterColumn("dbo.Years", "YearId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Years", "YearId");
            CreateIndex("dbo.YearStudents", "Student_Id");
            CreateIndex("dbo.YearStudents", "Year_YearId");
            AddForeignKey("dbo.Teachers", "TeacherId", "dbo.Years", "YearId");
            AddForeignKey("dbo.YearStudents", "Student_Id", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.YearStudents", "Year_YearId", "dbo.Years", "YearId", cascadeDelete: true);
        }
    }
}
