namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relsfixed123 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "Student_Id", c => c.Int());
            AddColumn("dbo.Students", "FileId", c => c.Int(nullable: false));
            CreateIndex("dbo.Files", "Student_Id");
            AddForeignKey("dbo.Files", "Student_Id", "dbo.Students", "Id", cascadeDelete : true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "Student_Id", "dbo.Students");
            DropIndex("dbo.Files", new[] { "Student_Id" });
            DropColumn("dbo.Students", "FileId");
            DropColumn("dbo.Files", "Student_Id");
        }
    }
}
