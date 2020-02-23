namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentsSubjects : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentsSubjects", "StudentId", c => c.Int(nullable: false));
            CreateIndex("dbo.StudentsSubjects", "StudentId");
            AddForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentsSubjects", new[] { "StudentId" });
            DropColumn("dbo.StudentsSubjects", "StudentId");
        }
    }
}
