namespace SkopjeCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Charging_station",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        longitude = c.Double(nullable: false),
                        latitude = c.Double(nullable: false),
                        amenity = c.String(),
                        fee = c.String(),
                        openingHours = c.String(),
                        operatorCS = c.String(),
                        socket = c.String(),
                        tip = c.String(),
                        address = c.String(),
                        municipality = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Charging_station");
        }
    }
}
