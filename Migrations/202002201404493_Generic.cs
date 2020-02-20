namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Generic : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders (GenderId,Name) VALUES ('1','MALE')");
            Sql("INSERT INTO Genders (GenderId,Name) VALUES ('2','FEMALE')");

            Sql("INSERT INTO Years (YearNumber,YearName) VALUES ('1','Primary 1')");
            Sql("INSERT INTO Years (YearNumber,YearName) VALUES ('2','Primary 2')");
            Sql("INSERT INTO Years (YearNumber,YearName) VALUES ('3','Primary 3')");
            Sql("INSERT INTO Years (YearNumber,YearName) VALUES ('4','Primary 4')");
            Sql("INSERT INTO Years (YearNumber,YearName) VALUES ('5','Primary 5')");
            Sql("INSERT INTO Years (YearNumber,YearName) VALUES ('6','Primary 6')");

        }

        public override void Down()
        {
        }
    }
}
