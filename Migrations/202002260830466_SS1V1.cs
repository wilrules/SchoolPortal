namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SS1V1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentsSubjects", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentsSubjects", new[] { "Student_Id" });
            RenameColumn(table: "dbo.StudentsSubjects", name: "Student_Id", newName: "StudentId");
            AlterColumn("dbo.StudentsSubjects", "StudentId", c => c.Int(nullable: true));
            CreateIndex("dbo.StudentsSubjects", "StudentId");
            AddForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentsSubjects", new[] { "StudentId" });
            AlterColumn("dbo.StudentsSubjects", "StudentId", c => c.Int());
            RenameColumn(table: "dbo.StudentsSubjects", name: "StudentId", newName: "Student_Id");
            CreateIndex("dbo.StudentsSubjects", "Student_Id");
            AddForeignKey("dbo.StudentsSubjects", "Student_Id", "dbo.Students", "Id");
        }
    }
}
