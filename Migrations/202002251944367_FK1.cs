namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "StudentAddressId", "dbo.StudentAddresses");
            DropIndex("dbo.Students", new[] { "StudentAddressId" });
            DropPrimaryKey("dbo.StudentAddresses");
            AlterColumn("dbo.StudentAddresses", "StudentAddressId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.StudentAddresses", "StudentAddressId");
            CreateIndex("dbo.StudentAddresses", "StudentAddressId");
            AddForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students", "Id");
            DropColumn("dbo.Students", "StudentAddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "StudentAddressId", c => c.Int(nullable: false));
            DropForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students");
            DropIndex("dbo.StudentAddresses", new[] { "StudentAddressId" });
            DropPrimaryKey("dbo.StudentAddresses");
            AlterColumn("dbo.StudentAddresses", "StudentAddressId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.StudentAddresses", "StudentAddressId");
            CreateIndex("dbo.Students", "StudentAddressId");
            AddForeignKey("dbo.Students", "StudentAddressId", "dbo.StudentAddresses", "StudentAddressId", cascadeDelete: true);
        }
    }
}
