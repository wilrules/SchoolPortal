namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stu1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "YearId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "YearId", c => c.Byte(nullable: false));
        }
    }
}
