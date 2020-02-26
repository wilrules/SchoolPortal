namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sqlfix : DbMigration
    {
        public override void Up()
        {
            Sql(@"ALTER TABLE [dbo].[StudentAddresses] DROP CONSTRAINT [FK_dbo.StudentAddresses_dbo.Students_StudentAddressId]");
        }
        
        public override void Down()
        {
        }
    }
}
