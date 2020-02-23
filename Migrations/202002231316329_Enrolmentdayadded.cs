namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Enrolmentdayadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "EnrolmentDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "EnrolmentDate");
        }
    }
}
