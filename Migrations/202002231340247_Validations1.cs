namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validations1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "MiddleName", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "MiddleName", c => c.String());
        }
    }
}
