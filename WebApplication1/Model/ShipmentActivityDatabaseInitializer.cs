using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CMS.Models
{
    //public class ShipmentActivityDatabaseInitializer : DropCreateDatabaseAlways<ShipmentActivityContext>
    public class ShipmentActivityDatabaseInitializer : DropCreateDatabaseIfModelChanges<ShipmentActivityContext>
    {
        protected override void Seed(ShipmentActivityContext context)
        {
            GetShipmentActivities().ForEach(c => context.ShipmentActivities.Add(c));
        }

        private static List<ShipmentActivity> GetShipmentActivities()
        {
            var ShipmentActitivies = new List<ShipmentActivity>
            {
                new ShipmentActivity
                {
                    ShipmentID = 1,
                    Shipname = "Maersk 1",
                    ShipmentSize = "200 Ton",
                    ShipmentDate = "07-February-2017",
                    ShipmentLocation = "Jakarta",
                    ShipmentStatus = "In Delivery"
                },
                new ShipmentActivity
                {
                    ShipmentID = 2,
                    Shipname = "Maersk 2",
                    ShipmentSize = "100 Ton",
                    ShipmentDate = "08-February-2017",
                    ShipmentLocation = "Shanghai",
                    ShipmentStatus = "Delivered"
                }
            };

            return ShipmentActitivies;
        }
    }
}