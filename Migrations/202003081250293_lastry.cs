namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastry : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", "Student_Id", "dbo.Students");
            DropIndex("dbo.Files", new[] { "Student_Id" });
            DropColumn("dbo.Files", "Student_Id");
            DropColumn("dbo.Students", "FileId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "FileId", c => c.Int(nullable: false));
            AddColumn("dbo.Files", "Student_Id", c => c.Int());
            CreateIndex("dbo.Files", "Student_Id");
            AddForeignKey("dbo.Files", "Student_Id", "dbo.Students", "Id");
        }
    }
}
