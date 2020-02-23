namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YearRels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Titles", "TitleId", "dbo.Teachers");
            DropForeignKey("dbo.Years", "YearId", "dbo.Teachers");
            DropForeignKey("dbo.Genders", "GenderId", "dbo.Students");
            DropForeignKey("dbo.Students", "Year_YearId", "dbo.Years");
            DropForeignKey("dbo.StudentsSubjects", "YearId", "dbo.Years");
            DropIndex("dbo.Genders", new[] { "GenderId" });
            DropIndex("dbo.Years", new[] { "YearId" });
            DropIndex("dbo.Titles", new[] { "TitleId" });
            DropPrimaryKey("dbo.Genders");
            DropPrimaryKey("dbo.Years");
            DropPrimaryKey("dbo.Titles");
            AlterColumn("dbo.Genders", "GenderId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Years", "YearId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Titles", "TitleId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Genders", "GenderId");
            AddPrimaryKey("dbo.Years", "YearId");
            AddPrimaryKey("dbo.Titles", "TitleId");
            AddForeignKey("dbo.Students", "Year_YearId", "dbo.Years", "YearId");
            AddForeignKey("dbo.StudentsSubjects", "YearId", "dbo.Years", "YearId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentsSubjects", "YearId", "dbo.Years");
            DropForeignKey("dbo.Students", "Year_YearId", "dbo.Years");
            DropPrimaryKey("dbo.Titles");
            DropPrimaryKey("dbo.Years");
            DropPrimaryKey("dbo.Genders");
            AlterColumn("dbo.Titles", "TitleId", c => c.Int(nullable: false));
            AlterColumn("dbo.Years", "YearId", c => c.Int(nullable: false));
            AlterColumn("dbo.Genders", "GenderId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Titles", "TitleId");
            AddPrimaryKey("dbo.Years", "YearId");
            AddPrimaryKey("dbo.Genders", "GenderId");
            CreateIndex("dbo.Titles", "TitleId");
            CreateIndex("dbo.Years", "YearId");
            CreateIndex("dbo.Genders", "GenderId");
            AddForeignKey("dbo.StudentsSubjects", "YearId", "dbo.Years", "YearId", cascadeDelete: true);
            AddForeignKey("dbo.Students", "Year_YearId", "dbo.Years", "YearId");
            AddForeignKey("dbo.Genders", "GenderId", "dbo.Students", "Id");
            AddForeignKey("dbo.Years", "YearId", "dbo.Teachers", "TeacherId");
            AddForeignKey("dbo.Titles", "TitleId", "dbo.Teachers", "TeacherId");
        }
    }
}
