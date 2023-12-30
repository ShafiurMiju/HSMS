namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminTableModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Admins", "ContactNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Admins", "Gender", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Admins", "DateOfBirth", c => c.String(nullable: false));
            AddColumn("dbo.Admins", "Password", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Admins", "Address", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "Address");
            DropColumn("dbo.Admins", "Password");
            DropColumn("dbo.Admins", "DateOfBirth");
            DropColumn("dbo.Admins", "Gender");
            DropColumn("dbo.Admins", "ContactNumber");
            DropColumn("dbo.Admins", "Email");
        }
    }
}
