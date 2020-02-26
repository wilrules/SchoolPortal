namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addressfix1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "StudentAddressId" });
            AddColumn("dbo.Students", "HouseNumberOrName", c => c.String(nullable: false));
            AddColumn("dbo.Students", "FirstLineofAdd", c => c.String(nullable: false));
            AddColumn("dbo.Students", "SecondLineofAdd", c => c.String(nullable: false));
            AddColumn("dbo.Students", "Area", c => c.String(nullable: false));
            DropTable("dbo.StudentAddresses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        StudentAddressId = c.Int(nullable: false),
                        HouseNumberOrName = c.String(nullable: false),
                        FirstLineofAdd = c.String(nullable: false),
                        SecondLineofAdd = c.String(nullable: false),
                        Area = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudentAddressId);
            
            DropColumn("dbo.Students", "Area");
            DropColumn("dbo.Students", "SecondLineofAdd");
            DropColumn("dbo.Students", "FirstLineofAdd");
            DropColumn("dbo.Students", "HouseNumberOrName");
            CreateIndex("dbo.StudentAddresses", "StudentAddressId");
            AddForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students", "Id");
        }
    }
}
