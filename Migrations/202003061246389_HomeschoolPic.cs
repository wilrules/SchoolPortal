namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HomeschoolPic : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", "Home_HomeId", "dbo.Homes");
            DropIndex("dbo.Files", new[] { "Home_HomeId" });
            RenameColumn(table: "dbo.Files", name: "Home_HomeId", newName: "HomeId");
            AddColumn("dbo.Homes", "Name", c => c.String());
            AlterColumn("dbo.Files", "HomeId", c => c.Int(nullable: true));
            CreateIndex("dbo.Files", "HomeId");
            AddForeignKey("dbo.Files", "HomeId", "dbo.Homes", "HomeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "HomeId", "dbo.Homes");
            DropIndex("dbo.Files", new[] { "HomeId" });
            AlterColumn("dbo.Files", "HomeId", c => c.Int());
            DropColumn("dbo.Homes", "Name");
            RenameColumn(table: "dbo.Files", name: "HomeId", newName: "Home_HomeId");
            CreateIndex("dbo.Files", "Home_HomeId");
            AddForeignKey("dbo.Files", "Home_HomeId", "dbo.Homes", "HomeId");
        }
    }
}
