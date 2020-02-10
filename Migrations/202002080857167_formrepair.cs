namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class formrepair : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Form_Id", "dbo.Forms");
            DropIndex("dbo.Students", new[] { "Form_Id" });
            DropColumn("dbo.Students", "Form_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Form_Id", c => c.Int());
            CreateIndex("dbo.Students", "Form_Id");
            AddForeignKey("dbo.Students", "Form_Id", "dbo.Forms", "Id");
        }
    }
}
