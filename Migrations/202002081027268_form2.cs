namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class form2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        FormId = c.Int(nullable: false, identity: true),
                        FormName = c.String(),
                        Section = c.String(),
                    })
                .PrimaryKey(t => t.FormId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Forms");
        }
    }
}
