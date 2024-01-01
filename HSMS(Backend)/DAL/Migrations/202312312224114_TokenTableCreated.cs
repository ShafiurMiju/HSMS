namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TokenTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(nullable: false, maxLength: 100),
                        LoggedTime = c.DateTime(nullable: false),
                        ExpiredTime = c.DateTime(nullable: false),
                        AdminID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Admins", t => t.AdminID, cascadeDelete: true)
                .Index(t => t.AdminID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "AdminID", "dbo.Admins");
            DropIndex("dbo.Tokens", new[] { "AdminID" });
            DropTable("dbo.Tokens");
        }
    }
}
