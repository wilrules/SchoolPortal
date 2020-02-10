namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trying : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Form_FormId", "dbo.Forms");
            DropIndex("dbo.Students", new[] { "Form_FormId" });
            DropColumn("dbo.Students", "FormId");
            DropColumn("dbo.Students", "Form_FormId");
            DropTable("dbo.Forms");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        FormId = c.Int(nullable: false, identity: true),
                        FormName = c.String(),
                        Section = c.String(),
                    })
                .PrimaryKey(t => t.FormId);
            
            AddColumn("dbo.Students", "Form_FormId", c => c.Int());
            AddColumn("dbo.Students", "FormId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Students", "Form_FormId");
            AddForeignKey("dbo.Students", "Form_FormId", "dbo.Forms", "FormId");
        }
    }
}
