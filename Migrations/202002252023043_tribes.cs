namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tribes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Tribes (TribeName) VALUES ('Igbo')");
            Sql("INSERT INTO Tribes (TribeName) VALUES ('Hausa')");
            Sql("INSERT INTO Tribes (TribeName) VALUES ('Yoruba')");
        }
        
        public override void Down()
        {
        }
    }
}
