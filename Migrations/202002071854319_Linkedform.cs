namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Linkedform : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "Form_Id", c => c.Int());
            CreateIndex("dbo.Students", "Form_Id");
            AddForeignKey("dbo.Students", "Form_Id", "dbo.Forms", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Form_Id", "dbo.Forms");
            DropIndex("dbo.Students", new[] { "Form_Id" });
            DropColumn("dbo.Students", "Form_Id");
            DropTable("dbo.Forms");
        }
    }
}
