namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relationshipfixer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "FileId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "FileId", c => c.Int(nullable: false));
        }
    }
}
