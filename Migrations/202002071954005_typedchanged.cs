namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typedchanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Forms", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Forms", "Name", c => c.Int(nullable: false));
        }
    }
}
