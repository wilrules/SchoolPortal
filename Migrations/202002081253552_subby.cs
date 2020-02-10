namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class subby : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Subject_Id", c => c.Int());
            CreateIndex("dbo.Students", "Subject_Id");
            AddForeignKey("dbo.Students", "Subject_Id", "dbo.Subjects", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Subject_Id", "dbo.Subjects");
            DropIndex("dbo.Students", new[] { "Subject_Id" });
            DropColumn("dbo.Students", "Subject_Id");
        }
    }
}
