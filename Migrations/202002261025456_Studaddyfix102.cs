namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Studaddyfix102 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        StudentAddressId = c.Int(nullable: true),
                        HouseNumberOrName = c.String(nullable: false),
                        FirstLineofAdd = c.String(nullable: false),
                        SecondLineofAdd = c.String(nullable: false),
                        Area = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudentAddressId)
                .ForeignKey("dbo.Students", t => t.StudentAddressId)
                .Index(t => t.StudentAddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "StudentAddressId" });
            DropTable("dbo.StudentAddresses");
        }
    }
}
