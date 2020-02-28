namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestDebug : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String(maxLength: 12));
            AlterColumn("dbo.Students", "Lastname", c => c.String(maxLength: 12));
            AlterColumn("dbo.Students", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.Students", "HouseNumberOrName", c => c.String());
            AlterColumn("dbo.Students", "FirstLineofAdd", c => c.String());
            AlterColumn("dbo.Students", "SecondLineofAdd", c => c.String());
            AlterColumn("dbo.Students", "Area", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Area", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "SecondLineofAdd", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "FirstLineofAdd", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "HouseNumberOrName", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "Lastname", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 12));
        }
    }
}
