namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yearremoved : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "Year");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Year", c => c.Byte(nullable: false));
        }
    }
}
