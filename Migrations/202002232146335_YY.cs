namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YY : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Year_YearId", "dbo.Years");
            DropIndex("dbo.Students", new[] { "Year_YearId" });
            RenameColumn(table: "dbo.Students", name: "Year_YearId", newName: "YearId");
            AlterColumn("dbo.Students", "YearId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "YearId");
            AddForeignKey("dbo.Students", "YearId", "dbo.Years", "YearId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "YearId", "dbo.Years");
            DropIndex("dbo.Students", new[] { "YearId" });
            AlterColumn("dbo.Students", "YearId", c => c.Int());
            RenameColumn(table: "dbo.Students", name: "YearId", newName: "Year_YearId");
            CreateIndex("dbo.Students", "Year_YearId");
            AddForeignKey("dbo.Students", "Year_YearId", "dbo.Years", "YearId");
        }
    }
}
