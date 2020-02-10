namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Type", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Type", c => c.String(nullable: false));
        }
    }
}
