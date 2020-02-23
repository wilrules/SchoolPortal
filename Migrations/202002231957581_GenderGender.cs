namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenderGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Gender_GenderId", c => c.Int());
            CreateIndex("dbo.Students", "Gender_GenderId");
            AddForeignKey("dbo.Students", "Gender_GenderId", "dbo.Genders", "GenderId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Gender_GenderId", "dbo.Genders");
            DropIndex("dbo.Students", new[] { "Gender_GenderId" });
            DropColumn("dbo.Students", "Gender_GenderId");
        }
    }
}
