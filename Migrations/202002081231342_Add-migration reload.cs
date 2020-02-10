namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addmigrationreload : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Subjects (Name,Passmark) VALUES ( 'Mathematics','70')");


        }
        
        public override void Down()
        {
        }
    }
}
