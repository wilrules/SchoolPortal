namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teachergone : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teachers", "TitleId", "dbo.Titles");
            DropForeignKey("dbo.Teachers", "TeacherId", "dbo.Years");
            DropIndex("dbo.Teachers", new[] { "TeacherId" });
            DropIndex("dbo.Teachers", new[] { "TitleId" });
            DropTable("dbo.Teachers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(nullable: false),
                        YearId = c.Int(nullable: false),
                        TitleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            CreateIndex("dbo.Teachers", "TitleId");
            CreateIndex("dbo.Teachers", "TeacherId");
            AddForeignKey("dbo.Teachers", "TeacherId", "dbo.Years", "YearId");
            AddForeignKey("dbo.Teachers", "TitleId", "dbo.Titles", "TitleId", cascadeDelete: true);
        }
    }
}
