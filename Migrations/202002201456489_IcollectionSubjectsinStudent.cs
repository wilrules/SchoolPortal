namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IcollectionSubjectsinStudent : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Subjects", "Student_Id", "dbo.Students");
            DropIndex("dbo.Subjects", new[] { "Student_Id" });
            RenameColumn(table: "dbo.Subjects", name: "Student_Id", newName: "StudentId");
            AddColumn("dbo.Subjects", "PassMark", c => c.Int());
            AlterColumn("dbo.Subjects", "StudentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Subjects", "StudentId");
            AddForeignKey("dbo.Subjects", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "StudentId", "dbo.Students");
            DropIndex("dbo.Subjects", new[] { "StudentId" });
            AlterColumn("dbo.Subjects", "StudentId", c => c.Int());
            DropColumn("dbo.Subjects", "PassMark");
            RenameColumn(table: "dbo.Subjects", name: "StudentId", newName: "Student_Id");
            CreateIndex("dbo.Subjects", "Student_Id");
            AddForeignKey("dbo.Subjects", "Student_Id", "dbo.Students", "Id");
        }
    }
}
