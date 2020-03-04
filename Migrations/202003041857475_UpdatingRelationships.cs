namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingRelationships : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentsSubjects", "SubjectsId", "dbo.Subjects");
            DropForeignKey("dbo.StudentsSubjects", "YearId", "dbo.Years");
            DropIndex("dbo.StudentsSubjects", new[] { "StudentId" });
            DropIndex("dbo.StudentsSubjects", new[] { "YearId" });
            DropIndex("dbo.StudentsSubjects", new[] { "SubjectsId" });
            AlterColumn("dbo.StudentsSubjects", "StudentId", c => c.Int());
            AlterColumn("dbo.StudentsSubjects", "YearId", c => c.Int());
            AlterColumn("dbo.StudentsSubjects", "SubjectsId", c => c.Int());
            CreateIndex("dbo.StudentsSubjects", "StudentId");
            CreateIndex("dbo.StudentsSubjects", "YearId");
            CreateIndex("dbo.StudentsSubjects", "SubjectsId");
            AddForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students", "Id");
            AddForeignKey("dbo.StudentsSubjects", "SubjectsId", "dbo.Subjects", "SubjectsId");
            AddForeignKey("dbo.StudentsSubjects", "YearId", "dbo.Years", "YearId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentsSubjects", "YearId", "dbo.Years");
            DropForeignKey("dbo.StudentsSubjects", "SubjectsId", "dbo.Subjects");
            DropForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentsSubjects", new[] { "SubjectsId" });
            DropIndex("dbo.StudentsSubjects", new[] { "YearId" });
            DropIndex("dbo.StudentsSubjects", new[] { "StudentId" });
            AlterColumn("dbo.StudentsSubjects", "SubjectsId", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentsSubjects", "YearId", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentsSubjects", "StudentId", c => c.Int(nullable: false));
            CreateIndex("dbo.StudentsSubjects", "SubjectsId");
            CreateIndex("dbo.StudentsSubjects", "YearId");
            CreateIndex("dbo.StudentsSubjects", "StudentId");
            AddForeignKey("dbo.StudentsSubjects", "YearId", "dbo.Years", "YearId", cascadeDelete: true);
            AddForeignKey("dbo.StudentsSubjects", "SubjectsId", "dbo.Subjects", "SubjectsId", cascadeDelete: true);
            AddForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
