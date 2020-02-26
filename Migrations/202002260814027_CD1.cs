namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CD1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentsSubjects", new[] { "StudentId" });
            RenameColumn(table: "dbo.StudentsSubjects", name: "StudentId", newName: "Student_Id");
            AlterColumn("dbo.StudentsSubjects", "Student_Id", c => c.Int());
            CreateIndex("dbo.StudentsSubjects", "Student_Id");
            AddForeignKey("dbo.StudentsSubjects", "Student_Id", "dbo.Students", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentsSubjects", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentsSubjects", new[] { "Student_Id" });
            AlterColumn("dbo.StudentsSubjects", "Student_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.StudentsSubjects", name: "Student_Id", newName: "StudentId");
            CreateIndex("dbo.StudentsSubjects", "StudentId");
            AddForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
