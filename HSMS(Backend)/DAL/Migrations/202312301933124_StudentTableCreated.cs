namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        FatherName = c.String(nullable: false, maxLength: 20),
                        MotherName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        ContactNumber = c.String(nullable: false, maxLength: 20),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 10),
                        Address = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 20),
                        ClassID = c.Int(nullable: false),
                        SectionID = c.Int(nullable: false),
                        AdmissionDate = c.DateTime(nullable: false),
                        ProfilePicture = c.String(),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.ClassID, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .Index(t => t.ClassID)
                .Index(t => t.SectionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "SectionID", "dbo.Sections");
            DropForeignKey("dbo.Students", "ClassID", "dbo.Classes");
            DropIndex("dbo.Students", new[] { "SectionID" });
            DropIndex("dbo.Students", new[] { "ClassID" });
            DropTable("dbo.Students");
        }
    }
}
