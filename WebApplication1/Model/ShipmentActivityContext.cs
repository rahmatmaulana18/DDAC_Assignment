//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.Data.Entity;

namespace CMS.Models
{
    public class ShipmentActivityContext : DbContext
    {
        public ShipmentActivityContext() : base("AzureDB")
            //AzureConnection
        {

        }

        public DbSet<ShipmentActivity> ShipmentActivities { get; set; }
    }
}