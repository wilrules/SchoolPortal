namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Subjects", "PassMark");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subjects", "PassMark", c => c.Int(nullable: false));
        }
    }
}
