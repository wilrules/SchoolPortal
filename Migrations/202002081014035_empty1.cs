namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empty1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Form_Id", "dbo.Forms");
            DropIndex("dbo.Students", new[] { "Form_Id" });
            DropColumn("dbo.Students", "Form_Id");
            DropTable("dbo.Forms");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "Form_Id", c => c.Int());
            CreateIndex("dbo.Students", "Form_Id");
            AddForeignKey("dbo.Students", "Form_Id", "dbo.Forms", "Id");
        }
    }
}
