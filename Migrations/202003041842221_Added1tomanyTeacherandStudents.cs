namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added1tomanyTeacherandStudents : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "TeacherId", c => c.Int());
            CreateIndex("dbo.Students", "TeacherId");
            AddForeignKey("dbo.Students", "TeacherId", "dbo.Teachers", "TeacherId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Students", new[] { "TeacherId" });
            DropColumn("dbo.Students", "TeacherId");
        }
    }
}
