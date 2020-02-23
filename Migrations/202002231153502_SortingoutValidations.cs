namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SortingoutValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentAddresses", "Address1", c => c.String(nullable: false));
            AlterColumn("dbo.StudentAddresses", "Address2", c => c.String(nullable: false));
            AlterColumn("dbo.StudentAddresses", "City", c => c.String(nullable: false));
            DropColumn("dbo.Students", "EmailAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "EmailAddress", c => c.String());
            AlterColumn("dbo.StudentAddresses", "City", c => c.String());
            AlterColumn("dbo.StudentAddresses", "Address2", c => c.String());
            AlterColumn("dbo.StudentAddresses", "Address1", c => c.String());
        }
    }
}
