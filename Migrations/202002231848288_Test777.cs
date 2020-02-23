namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test777 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentsSubjects", new[] { "StudentId" });
            DropColumn("dbo.StudentsSubjects", "StudentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentsSubjects", "StudentId", c => c.Int(nullable: false));
            CreateIndex("dbo.StudentsSubjects", "StudentId");
            AddForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
