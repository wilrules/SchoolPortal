namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Generic3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Years (YearId,YearNumber,YearName) VALUES ('1','1','Primary 1')");
            Sql("INSERT INTO Years (YearId,YearNumber,YearName) VALUES ('2','2','Primary 2')");
            Sql("INSERT INTO Years (YearId,YearNumber,YearName) VALUES ('3','3','Primary 3')");
            Sql("INSERT INTO Years (YearId,YearNumber,YearName) VALUES ('4','4','Primary 4')");
            Sql("INSERT INTO Years (YearId,YearNumber,YearName) VALUES ('5','5','Primary 5')");
            Sql("INSERT INTO Years (YearId,YearNumber,YearName) VALUES ('6','6','Primary 6')");
        }
        
        public override void Down()
        {
        }
    }
}
