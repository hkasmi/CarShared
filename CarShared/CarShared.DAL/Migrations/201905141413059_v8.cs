namespace CarShared.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Country = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId);
            
            AddColumn("dbo.Trips", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.Trips", "DepartureCity", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trips", "DepartureCity", c => c.String(nullable: false));
            DropColumn("dbo.Trips", "Country");
            DropTable("dbo.Cities");
        }
    }
}
