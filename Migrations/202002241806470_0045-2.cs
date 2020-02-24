namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _00452 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Subjects", "SubjectName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Subjects", "PassMark", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subjects", "PassMark", c => c.Int());
            AlterColumn("dbo.Subjects", "SubjectName", c => c.String());
        }
    }
}
