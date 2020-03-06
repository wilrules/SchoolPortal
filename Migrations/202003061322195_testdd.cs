namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testdd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", "StudentId", "dbo.Students");
            DropIndex("dbo.Files", new[] { "StudentId" });
            RenameColumn(table: "dbo.Files", name: "StudentId", newName: "Student_Id");
            AlterColumn("dbo.Files", "Student_Id", c => c.Int());
            CreateIndex("dbo.Files", "Student_Id");
            AddForeignKey("dbo.Files", "Student_Id", "dbo.Students", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "Student_Id", "dbo.Students");
            DropIndex("dbo.Files", new[] { "Student_Id" });
            AlterColumn("dbo.Files", "Student_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Files", name: "Student_Id", newName: "StudentId");
            CreateIndex("dbo.Files", "StudentId");
            AddForeignKey("dbo.Files", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
