namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resetall : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Years", "TeacherId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Years", "TeacherId", c => c.Int(nullable: false));
        }
    }
}
