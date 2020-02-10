namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wayout : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "FormId", "dbo.Forms");
            DropIndex("dbo.Students", new[] { "FormId" });
            RenameColumn(table: "dbo.Students", name: "FormId", newName: "Form_Id");
            AlterColumn("dbo.Students", "Form_Id", c => c.Int());
            CreateIndex("dbo.Students", "Form_Id");
            AddForeignKey("dbo.Students", "Form_Id", "dbo.Forms", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Form_Id", "dbo.Forms");
            DropIndex("dbo.Students", new[] { "Form_Id" });
            AlterColumn("dbo.Students", "Form_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Students", name: "Form_Id", newName: "FormId");
            CreateIndex("dbo.Students", "FormId");
            AddForeignKey("dbo.Students", "FormId", "dbo.Forms", "Id", cascadeDelete: true);
        }
    }
}
