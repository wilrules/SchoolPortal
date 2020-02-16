namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false),
                        Title = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Years", t => t.TeacherId)
                .Index(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "TeacherId", "dbo.Years");
            DropIndex("dbo.Teachers", new[] { "TeacherId" });
            DropTable("dbo.Teachers");
        }
    }
}
