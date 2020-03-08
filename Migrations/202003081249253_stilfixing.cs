namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stilfixing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "FileId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "FileId");
        }
    }
}
