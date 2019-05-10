namespace CarShared.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "TripDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Trips", "NumberOfSpots", c => c.Int(nullable: false));
            AlterColumn("dbo.Trips", "DepartureCity", c => c.String(nullable: false));
            AlterColumn("dbo.Trips", "ArrivalCity", c => c.String(nullable: false));
            DropColumn("dbo.Trips", "Time");
            DropColumn("dbo.Trips", "SpotNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "SpotNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Trips", "Time", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Trips", "ArrivalCity", c => c.String());
            AlterColumn("dbo.Trips", "DepartureCity", c => c.String());
            DropColumn("dbo.Trips", "NumberOfSpots");
            DropColumn("dbo.Trips", "TripDate");
        }
    }
}
