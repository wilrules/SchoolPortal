namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropdownissues : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Gender_GenderId", "dbo.Genders");
            DropIndex("dbo.Students", new[] { "Gender_GenderId" });
            RenameColumn(table: "dbo.Students", name: "Gender_GenderId", newName: "GenderId");
            AlterColumn("dbo.Students", "GenderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "GenderId");
            AddForeignKey("dbo.Students", "GenderId", "dbo.Genders", "GenderId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "GenderId", "dbo.Genders");
            DropIndex("dbo.Students", new[] { "GenderId" });
            AlterColumn("dbo.Students", "GenderId", c => c.Int());
            RenameColumn(table: "dbo.Students", name: "GenderId", newName: "Gender_GenderId");
            CreateIndex("dbo.Students", "Gender_GenderId");
            AddForeignKey("dbo.Students", "Gender_GenderId", "dbo.Genders", "GenderId");
        }
    }
}
