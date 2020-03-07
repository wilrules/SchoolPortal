namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appdb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", "Home_HomeId", "dbo.Homes");
            DropIndex("dbo.Files", new[] { "Home_HomeId" });
            DropColumn("dbo.Files", "Home_HomeId");
            DropTable("dbo.Homes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Homes",
                c => new
                    {
                        HomeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HomeId);
            
            AddColumn("dbo.Files", "Home_HomeId", c => c.Int());
            CreateIndex("dbo.Files", "Home_HomeId");
            AddForeignKey("dbo.Files", "Home_HomeId", "dbo.Homes", "HomeId");
        }
    }
}
