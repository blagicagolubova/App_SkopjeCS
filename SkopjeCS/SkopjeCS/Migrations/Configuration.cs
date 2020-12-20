namespace SkopjeCS.Migrations
{
    using SkopjeCS.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SkopjeCS.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SkopjeCS.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Blagica\\Desktop\\finalen_csv.csv");
            string line = file.ReadLine();
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');

                Charging_station scs = new Charging_station();
                int id = Int32.Parse(parts[0].ToString());
                scs.id = id;
                scs.longitude = Double.Parse(parts[1]);
                scs.latitude = Double.Parse(parts[2]);
                scs.amenity = parts[3];
                scs.fee = parts[4];
                scs.openingHours = parts[5];
                scs.operatorCS = parts[6];
                scs.socket = parts[7];
                scs.tip = parts[8];
                scs.address = parts[9];
                scs.municipality = parts[10];

                var existsInDb = context.Charging_station
                .Where(c => c.id == scs.id)
                .SingleOrDefault();
                if (existsInDb != null)
                    context.Charging_station.AddOrUpdate(scs);
                else
                    context.Charging_station.Add(scs);
            }
        }
    }
}
