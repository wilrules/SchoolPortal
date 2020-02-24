namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YearId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subjects", "YearId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subjects", "YearId");
        }
    }
}
