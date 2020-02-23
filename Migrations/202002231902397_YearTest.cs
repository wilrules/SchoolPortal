namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YearTest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Year_YearId", "dbo.Years");
            DropIndex("dbo.Students", new[] { "Year_YearId" });
            DropColumn("dbo.Students", "Year_YearId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Year_YearId", c => c.Int());
            CreateIndex("dbo.Students", "Year_YearId");
            AddForeignKey("dbo.Students", "Year_YearId", "dbo.Years", "YearId");
        }
    }
}
