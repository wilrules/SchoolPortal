namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GenderId)
                .ForeignKey("dbo.Students", t => t.GenderId)
                .Index(t => t.GenderId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 12),
                        MiddleName = c.String(maxLength: 12),
                        Lastname = c.String(nullable: false, maxLength: 12),
                        DateOfBirth = c.DateTime(nullable: false),
                        EnrolmentDate = c.DateTime(nullable: false),
                        Year_YearId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Years", t => t.Year_YearId)
                .Index(t => t.Year_YearId);
            
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        StudentAddressId = c.Int(nullable: false),
                        Address1 = c.String(nullable: false),
                        Address2 = c.String(nullable: false),
                        Address3 = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.StudentAddressId)
                .ForeignKey("dbo.Students", t => t.StudentAddressId)
                .Index(t => t.StudentAddressId);
            
            CreateTable(
                "dbo.StudentsSubjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Scores = c.Int(),
                        StudentId = c.Int(nullable: false),
                        YearId = c.Int(nullable: false),
                        SubjectsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: false)
                .ForeignKey("dbo.Subjects", t => t.SubjectsId, cascadeDelete: false)
                .ForeignKey("dbo.Years", t => t.YearId, cascadeDelete: false)
                .Index(t => t.StudentId)
                .Index(t => t.YearId)
                .Index(t => t.SubjectsId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectsId = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                        PassMark = c.Int(),
                        YearId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectsId);
            
            CreateTable(
                "dbo.Years",
                c => new
                    {
                        YearId = c.Int(nullable: false),
                        YearNumber = c.Int(nullable: false),
                        YearName = c.String(),
                    })
                .PrimaryKey(t => t.YearId)
                .ForeignKey("dbo.Teachers", t => t.YearId)
                .Index(t => t.YearId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            CreateTable(
                "dbo.Titles",
                c => new
                    {
                        TitleId = c.Int(nullable: false),
                        TitleName = c.String(),
                    })
                .PrimaryKey(t => t.TitleId)
                .ForeignKey("dbo.Teachers", t => t.TitleId)
                .Index(t => t.TitleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Genders", "GenderId", "dbo.Students");
            DropForeignKey("dbo.Years", "YearId", "dbo.Teachers");
            DropForeignKey("dbo.Titles", "TitleId", "dbo.Teachers");
            DropForeignKey("dbo.StudentsSubjects", "YearId", "dbo.Years");
            DropForeignKey("dbo.Students", "Year_YearId", "dbo.Years");
            DropForeignKey("dbo.StudentsSubjects", "SubjectsId", "dbo.Subjects");
            DropForeignKey("dbo.StudentsSubjects", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Titles", new[] { "TitleId" });
            DropIndex("dbo.Years", new[] { "YearId" });
            DropIndex("dbo.StudentsSubjects", new[] { "SubjectsId" });
            DropIndex("dbo.StudentsSubjects", new[] { "YearId" });
            DropIndex("dbo.StudentsSubjects", new[] { "StudentId" });
            DropIndex("dbo.StudentAddresses", new[] { "StudentAddressId" });
            DropIndex("dbo.Students", new[] { "Year_YearId" });
            DropIndex("dbo.Genders", new[] { "GenderId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Titles");
            DropTable("dbo.Teachers");
            DropTable("dbo.Years");
            DropTable("dbo.Subjects");
            DropTable("dbo.StudentsSubjects");
            DropTable("dbo.StudentAddresses");
            DropTable("dbo.Students");
            DropTable("dbo.Genders");
        }
    }
}
