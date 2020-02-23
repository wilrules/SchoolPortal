namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Generic : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Titles (TitleId,TitleName) VALUES ('1','Mr')");
            Sql("INSERT INTO Titles (TitleId,TitleName) VALUES ('2','Mrs')");
            Sql("INSERT INTO Titles (TitleId,TitleName) VALUES ('3','Ms')");
            Sql("INSERT INTO Titles (TitleId,TitleName) VALUES ('4','Miss')");
        }
        
        public override void Down()
        {
        }
    }
}
