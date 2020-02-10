namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lolo : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Forms (Name) VALUES ( 'Form-1')");
        }
        
        public override void Down()
        {
        }
    }
}
