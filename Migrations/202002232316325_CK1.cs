namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CK1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(nullable: false),
                        YearId = c.Int(nullable: false),
                        TitleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Titles", t => t.TitleId, cascadeDelete: false)
                .ForeignKey("dbo.Years", t => t.YearId, cascadeDelete: false)
                .Index(t => t.YearId)
                .Index(t => t.TitleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "YearId", "dbo.Years");
            DropForeignKey("dbo.Teachers", "TitleId", "dbo.Titles");
            DropIndex("dbo.Teachers", new[] { "TitleId" });
            DropIndex("dbo.Teachers", new[] { "YearId" });
            DropTable("dbo.Teachers");
        }
    }
}
