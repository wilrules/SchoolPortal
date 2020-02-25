namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0030and0031 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Religions",
                c => new
                    {
                        ReligionId = c.Int(nullable: false, identity: true),
                        ReligionName = c.String(),
                    })
                .PrimaryKey(t => t.ReligionId);
            
            CreateTable(
                "dbo.Tribes",
                c => new
                    {
                        TribeId = c.Int(nullable: false, identity: true),
                        TribeName = c.String(),
                    })
                .PrimaryKey(t => t.TribeId);
            
            AddColumn("dbo.Students", "ReligionId", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "TribeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "ReligionId");
            CreateIndex("dbo.Students", "TribeId");
            AddForeignKey("dbo.Students", "ReligionId", "dbo.Religions", "ReligionId", cascadeDelete: false);
            AddForeignKey("dbo.Students", "TribeId", "dbo.Tribes", "TribeId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "TribeId", "dbo.Tribes");
            DropForeignKey("dbo.Students", "ReligionId", "dbo.Religions");
            DropIndex("dbo.Students", new[] { "TribeId" });
            DropIndex("dbo.Students", new[] { "ReligionId" });
            DropColumn("dbo.Students", "TribeId");
            DropColumn("dbo.Students", "ReligionId");
            DropTable("dbo.Tribes");
            DropTable("dbo.Religions");
        }
    }
}
