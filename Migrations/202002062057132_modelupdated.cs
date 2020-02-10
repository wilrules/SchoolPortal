namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelupdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Type", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Students", "Lastname", c => c.String(nullable: false, maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Lastname", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            DropColumn("dbo.Students", "Type");
        }
    }
}
