namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empy : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Form_Id", "dbo.Forms");
            DropPrimaryKey("dbo.Forms");
            AlterColumn("dbo.Forms", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Forms", "Id");
            AddForeignKey("dbo.Students", "Form_Id", "dbo.Forms", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Form_Id", "dbo.Forms");
            DropPrimaryKey("dbo.Forms");
            AlterColumn("dbo.Forms", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Forms", "Id");
            AddForeignKey("dbo.Students", "Form_Id", "dbo.Forms", "Id");
        }
    }
}
