namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class y : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Forms (Name) VALUES ( 'Form-1')");
            Sql("INSERT INTO Forms (Name) VALUES ( 'Form-2')");
            Sql("INSERT INTO Forms (Name) VALUES ( 'Form-3')");
            Sql("INSERT INTO Forms (Name) VALUES ( 'Form-4')");
            Sql("INSERT INTO Forms (Name) VALUES ( 'Form-5')");
            Sql("INSERT INTO Forms (Name) VALUES ( 'Form-6')");
        }
        
        public override void Down()
        {
        }
    }
}
