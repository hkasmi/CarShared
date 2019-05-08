namespace CarShared.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        TripId = c.Int(nullable: false, identity: true),
                        DepartureCity = c.String(),
                        ArrivalCity = c.String(),
                        IdDriver = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                        SpotNumber = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TripId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trips");
        }
    }
}
