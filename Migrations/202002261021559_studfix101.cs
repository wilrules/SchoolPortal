namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studfix101 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentAddresses", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "Student_Id" });
            DropTable("dbo.StudentAddresses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        StudentAddressId = c.Int(nullable: false, identity: true),
                        HouseNumberOrName = c.String(nullable: false),
                        FirstLineofAdd = c.String(nullable: false),
                        SecondLineofAdd = c.String(nullable: false),
                        Area = c.String(nullable: false),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.StudentAddressId);
            
            CreateIndex("dbo.StudentAddresses", "Student_Id");
            AddForeignKey("dbo.StudentAddresses", "Student_Id", "dbo.Students", "Id");
        }
    }
}
