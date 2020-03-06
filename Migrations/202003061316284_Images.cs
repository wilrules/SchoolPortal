namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Images : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", "HomeId", "dbo.Homes");
            DropIndex("dbo.Files", new[] { "HomeId" });
            RenameColumn(table: "dbo.Files", name: "HomeId", newName: "Home_HomeId");
            AlterColumn("dbo.Files", "Home_HomeId", c => c.Int());
            CreateIndex("dbo.Files", "Home_HomeId");
            AddForeignKey("dbo.Files", "Home_HomeId", "dbo.Homes", "HomeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "Home_HomeId", "dbo.Homes");
            DropIndex("dbo.Files", new[] { "Home_HomeId" });
            AlterColumn("dbo.Files", "Home_HomeId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Files", name: "Home_HomeId", newName: "HomeId");
            CreateIndex("dbo.Files", "HomeId");
            AddForeignKey("dbo.Files", "HomeId", "dbo.Homes", "HomeId", cascadeDelete: true);
        }
    }
}
