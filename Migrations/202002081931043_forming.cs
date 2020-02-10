namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forming : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Form_Id", "dbo.Forms");
            DropIndex("dbo.Students", new[] { "Form_Id" });
            RenameColumn(table: "dbo.Students", name: "Form_Id", newName: "FormId");
            AlterColumn("dbo.Students", "FormId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "FormId");
            AddForeignKey("dbo.Students", "FormId", "dbo.Forms", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "FormId", "dbo.Forms");
            DropIndex("dbo.Students", new[] { "FormId" });
            AlterColumn("dbo.Students", "FormId", c => c.Int());
            RenameColumn(table: "dbo.Students", name: "FormId", newName: "Form_Id");
            CreateIndex("dbo.Students", "Form_Id");
            AddForeignKey("dbo.Students", "Form_Id", "dbo.Forms", "Id");
        }
    }
}
