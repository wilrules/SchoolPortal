namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestSubjectAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectsId = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                        PassMark = c.Int(),
                        StudentsSubjects_Id = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectsId)
                .ForeignKey("dbo.StudentsSubjects", t => t.StudentsSubjects_Id)
                .Index(t => t.StudentsSubjects_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "StudentsSubjects_Id", "dbo.StudentsSubjects");
            DropIndex("dbo.Subjects", new[] { "StudentsSubjects_Id" });
            DropTable("dbo.Subjects");
        }
    }
}
