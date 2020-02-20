namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Yeartosubject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subjects", "Year_YearId", c => c.Int());
            CreateIndex("dbo.Subjects", "Year_YearId");
            AddForeignKey("dbo.Subjects", "Year_YearId", "dbo.Years", "YearId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "Year_YearId", "dbo.Years");
            DropIndex("dbo.Subjects", new[] { "Year_YearId" });
            DropColumn("dbo.Subjects", "Year_YearId");
        }
    }
}
