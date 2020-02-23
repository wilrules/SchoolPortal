namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YeartoTeacher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "YearId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "YearId");
        }
    }
}
