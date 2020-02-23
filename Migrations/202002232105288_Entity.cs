namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentAddresses", "Address3", c => c.String());
            AlterColumn("dbo.StudentAddresses", "City", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentAddresses", "City", c => c.String(nullable: false));
            AlterColumn("dbo.StudentAddresses", "Address3", c => c.String(nullable: false));
        }
    }
}
