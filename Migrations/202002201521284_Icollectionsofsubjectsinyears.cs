namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Icollectionsofsubjectsinyears : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subjects", "YearId", c => c.Int(nullable: false));
            CreateIndex("dbo.Subjects", "YearId");
            AddForeignKey("dbo.Subjects", "YearId", "dbo.Years", "YearId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "YearId", "dbo.Years");
            DropIndex("dbo.Subjects", new[] { "YearId" });
            DropColumn("dbo.Subjects", "YearId");
        }
    }
}
