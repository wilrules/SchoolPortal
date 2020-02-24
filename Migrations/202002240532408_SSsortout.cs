namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SSsortout : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.StudentsSubjects", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentsSubjects", "Name", c => c.String());
        }
    }
}
