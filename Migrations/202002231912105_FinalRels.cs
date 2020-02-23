namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalRels : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Subjects", "YearId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subjects", "YearId", c => c.Int(nullable: false));
        }
    }
}
