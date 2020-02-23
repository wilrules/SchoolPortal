namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TitletoTeacher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "TitleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Teachers", "TitleId");
            AddForeignKey("dbo.Teachers", "TitleId", "dbo.Titles", "TitleId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "TitleId", "dbo.Titles");
            DropIndex("dbo.Teachers", new[] { "TitleId" });
            DropColumn("dbo.Teachers", "TitleId");
        }
    }
}
