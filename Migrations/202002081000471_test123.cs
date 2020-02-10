namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test123 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "FormId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "FormId");
        }
    }
}
