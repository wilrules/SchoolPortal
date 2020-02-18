namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignRemoved : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Years", "YearId", "dbo.Students");
            DropForeignKey("dbo.Teachers", "TeacherId", "dbo.Years");
            DropIndex("dbo.Years", new[] { "YearId" });
            DropPrimaryKey("dbo.Years");
            AddColumn("dbo.Students", "Year_YearId", c => c.Int());
            AlterColumn("dbo.Years", "YearId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Years", "YearId");
            CreateIndex("dbo.Students", "Year_YearId");
            AddForeignKey("dbo.Students", "Year_YearId", "dbo.Years", "YearId");
            AddForeignKey("dbo.Teachers", "TeacherId", "dbo.Years", "YearId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "TeacherId", "dbo.Years");
            DropForeignKey("dbo.Students", "Year_YearId", "dbo.Years");
            DropIndex("dbo.Students", new[] { "Year_YearId" });
            DropPrimaryKey("dbo.Years");
            AlterColumn("dbo.Years", "YearId", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "Year_YearId");
            AddPrimaryKey("dbo.Years", "YearId");
            CreateIndex("dbo.Years", "YearId");
            AddForeignKey("dbo.Teachers", "TeacherId", "dbo.Years", "YearId");
            AddForeignKey("dbo.Years", "YearId", "dbo.Students", "Id");
        }
    }
}
