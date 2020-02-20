namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubjectAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentsSubjects", "Scores", c => c.Int());
            DropColumn("dbo.StudentsSubjects", "PassMark");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentsSubjects", "PassMark", c => c.Int());
            DropColumn("dbo.StudentsSubjects", "Scores");
        }
    }
}
