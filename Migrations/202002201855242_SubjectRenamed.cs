namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubjectRenamed : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Subjects", newName: "StudentsSubjects");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.StudentsSubjects", newName: "Subjects");
        }
    }
}
