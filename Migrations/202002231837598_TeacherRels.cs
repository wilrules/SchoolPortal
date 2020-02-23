namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherRels : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Teachers");
            AlterColumn("dbo.Teachers", "TeacherId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Teachers", "TeacherId");
            CreateIndex("dbo.Teachers", "TeacherId");
            AddForeignKey("dbo.Teachers", "TeacherId", "dbo.Years", "YearId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "TeacherId", "dbo.Years");
            DropIndex("dbo.Teachers", new[] { "TeacherId" });
            DropPrimaryKey("dbo.Teachers");
            AlterColumn("dbo.Teachers", "TeacherId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Teachers", "TeacherId");
        }
    }
}
