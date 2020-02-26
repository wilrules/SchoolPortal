namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addyfix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "StudentAddressId" });
            DropPrimaryKey("dbo.StudentAddresses");
            AddColumn("dbo.StudentAddresses", "Student_Id", c => c.Int());
            AlterColumn("dbo.StudentAddresses", "StudentAddressId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.StudentAddresses", "StudentAddressId");
            CreateIndex("dbo.StudentAddresses", "Student_Id");
            AddForeignKey("dbo.StudentAddresses", "Student_Id", "dbo.Students", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "Student_Id" });
            DropPrimaryKey("dbo.StudentAddresses");
            AlterColumn("dbo.StudentAddresses", "StudentAddressId", c => c.Int(nullable: false));
            DropColumn("dbo.StudentAddresses", "Student_Id");
            AddPrimaryKey("dbo.StudentAddresses", "StudentAddressId");
            CreateIndex("dbo.StudentAddresses", "StudentAddressId");
            AddForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students", "Id");
        }
    }
}
