namespace CarShared.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Age", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "DateOfBirth");
        }
    }
}
