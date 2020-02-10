namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class going : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Forms (Name) VALUES ( 'FORM-1')");
            Sql("INSERT INTO Forms (Name) VALUES ( 'FORM-2')");
            Sql("INSERT INTO Forms (Name) VALUES ( 'FORM-3')");
            Sql("INSERT INTO Forms (Name) VALUES ( 'FORM-4')");
            Sql("INSERT INTO Forms (Name) VALUES ( 'FORM-5')");
            Sql("INSERT INTO Forms (Name) VALUES ( 'FORM-6')");
        }
        
        public override void Down()
        {
        }
    }
}
