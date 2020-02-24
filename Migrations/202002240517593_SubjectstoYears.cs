namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubjectstoYears : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Years", "Subjects_SubjectsId", c => c.Int());
            CreateIndex("dbo.Years", "Subjects_SubjectsId");
            AddForeignKey("dbo.Years", "Subjects_SubjectsId", "dbo.Subjects", "SubjectsId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Years", "Subjects_SubjectsId", "dbo.Subjects");
            DropIndex("dbo.Years", new[] { "Subjects_SubjectsId" });
            DropColumn("dbo.Years", "Subjects_SubjectsId");
        }
    }
}
