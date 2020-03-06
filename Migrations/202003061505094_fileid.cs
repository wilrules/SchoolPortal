namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fileid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Homes", "FileId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Homes", "FileId");
        }
    }
}
