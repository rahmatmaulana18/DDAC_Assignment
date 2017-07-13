using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Models;

namespace CMS
{
    public partial class Delete_Info : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void deleteRecord(object sender, EventArgs e)
        {
            var db = new ShipmentActivityContext();
            IQueryable<ShipmentActivity> query = db.ShipmentActivities;
            int sid = Int32.Parse(shipmentid.Value);
            query = query.Where(p => p.ShipmentID == sid);
            if (query.Count() != 0) {
                db.Entry(query.First()).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public IQueryable<ShipmentActivity> getShipmentList()
        {
            var db = new ShipmentActivityContext();
            IQueryable<ShipmentActivity> query = db.ShipmentActivities;
            System.Diagnostics.Debug.WriteLine("CMS Debug: Querying Shipment Activities");
            return query;
        }
    }
}