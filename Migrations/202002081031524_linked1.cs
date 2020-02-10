namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class linked1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Form_FormId", c => c.Int());
            CreateIndex("dbo.Students", "Form_FormId");
            AddForeignKey("dbo.Students", "Form_FormId", "dbo.Forms", "FormId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Form_FormId", "dbo.Forms");
            DropIndex("dbo.Students", new[] { "Form_FormId" });
            DropColumn("dbo.Students", "Form_FormId");
        }
    }
}
