namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminTableModified2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "ContactNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Admins", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "DateOfBirth", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "ContactNumber", c => c.Int(nullable: false));
        }
    }
}
