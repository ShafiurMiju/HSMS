namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentTableUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Password", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Password", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
