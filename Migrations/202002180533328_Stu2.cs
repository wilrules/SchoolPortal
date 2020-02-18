namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stu2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Year_YearId", "dbo.Years");
            DropIndex("dbo.Students", new[] { "Year_YearId" });
            RenameColumn(table: "dbo.Students", name: "Year_YearId", newName: "YearId");
            AddColumn("dbo.Teachers", "YearId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "YearId", c => c.Int(nullable: true));
            CreateIndex("dbo.Students", "YearId");
            AddForeignKey("dbo.Students", "YearId", "dbo.Years", "YearId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "YearId", "dbo.Years");
            DropIndex("dbo.Students", new[] { "YearId" });
            AlterColumn("dbo.Students", "YearId", c => c.Int());
            DropColumn("dbo.Teachers", "YearId");
            RenameColumn(table: "dbo.Students", name: "YearId", newName: "Year_YearId");
            CreateIndex("dbo.Students", "Year_YearId");
            AddForeignKey("dbo.Students", "Year_YearId", "dbo.Years", "YearId");
        }
    }
}
