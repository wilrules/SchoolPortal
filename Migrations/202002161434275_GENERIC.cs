namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GENERIC : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders (GenderId,Name) VALUES ('1','MALE')");
            Sql("INSERT INTO Genders (GenderId,Name) VALUES ('2','FEMALE')");
        }
        
        public override void Down()
        {
        }
    }
}
