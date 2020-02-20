namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FFID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Subjects", "Year_YearId", "dbo.Years");
            DropIndex("dbo.Subjects", new[] { "Year_YearId" });
            AddColumn("dbo.Subjects", "YearId", c => c.Int(nullable: true));
            DropColumn("dbo.Subjects", "Year_YearId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subjects", "Year_YearId", c => c.Int());
            DropColumn("dbo.Subjects", "YearId");
            CreateIndex("dbo.Subjects", "Year_YearId");
            AddForeignKey("dbo.Subjects", "Year_YearId", "dbo.Years", "YearId");
        }
    }
}
