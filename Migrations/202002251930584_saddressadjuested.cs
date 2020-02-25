namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saddressadjuested : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentAddresses", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "Student_Id" });
            AddColumn("dbo.StudentAddresses", "HouseNumberOrName", c => c.String(nullable: false));
            AddColumn("dbo.StudentAddresses", "FirstLineofAdd", c => c.String(nullable: false));
            AddColumn("dbo.StudentAddresses", "SecondLineofAdd", c => c.String(nullable: false));
            AddColumn("dbo.StudentAddresses", "Area", c => c.String(nullable: false));
            AddColumn("dbo.Students", "StudentAddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "StudentAddressId");
            AddForeignKey("dbo.Students", "StudentAddressId", "dbo.StudentAddresses", "StudentAddressId", cascadeDelete: false);
            DropColumn("dbo.StudentAddresses", "Address1");
            DropColumn("dbo.StudentAddresses", "Address2");
            DropColumn("dbo.StudentAddresses", "Address3");
            DropColumn("dbo.StudentAddresses", "City");
            DropColumn("dbo.StudentAddresses", "State");
            DropColumn("dbo.StudentAddresses", "Student_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentAddresses", "Student_Id", c => c.Int());
            AddColumn("dbo.StudentAddresses", "State", c => c.String());
            AddColumn("dbo.StudentAddresses", "City", c => c.String());
            AddColumn("dbo.StudentAddresses", "Address3", c => c.String());
            AddColumn("dbo.StudentAddresses", "Address2", c => c.String(nullable: false));
            AddColumn("dbo.StudentAddresses", "Address1", c => c.String(nullable: false));
            DropForeignKey("dbo.Students", "StudentAddressId", "dbo.StudentAddresses");
            DropIndex("dbo.Students", new[] { "StudentAddressId" });
            DropColumn("dbo.Students", "StudentAddressId");
            DropColumn("dbo.StudentAddresses", "Area");
            DropColumn("dbo.StudentAddresses", "SecondLineofAdd");
            DropColumn("dbo.StudentAddresses", "FirstLineofAdd");
            DropColumn("dbo.StudentAddresses", "HouseNumberOrName");
            CreateIndex("dbo.StudentAddresses", "Student_Id");
            AddForeignKey("dbo.StudentAddresses", "Student_Id", "dbo.Students", "Id");
        }
    }
}
