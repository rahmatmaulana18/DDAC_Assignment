using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Models;

namespace CMS
{
    public partial class Update_Info : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void updateRecord(object sender, EventArgs e)
        {
            int sid = Int32.Parse(shipmentid.Value);
            var newshipinfo = new ShipmentActivity
            {
                ShipmentID = sid,
                Shipname = shipname.Value,
                ShipmentSize = shipmentsize.Value,
                ShipmentDate = shipmentdate.Value,
                ShipmentLocation = shipmentlocation.Value,
                ShipmentStatus = shipmentstatus.Value
            };

            var db = new ShipmentActivityContext();
            db.Entry(newshipinfo).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            Response.Redirect(Request.RawUrl);
        }

        protected void getRecord(object sender, EventArgs e)
        {
            var db = new ShipmentActivityContext();
            IQueryable<ShipmentActivity> query = db.ShipmentActivities;
            int sid = Int32.Parse(shipmentid.Value);
            query = query.Where(p => p.ShipmentID == sid);
            var shipdata = query.First();
            shipname.Value = shipdata.Shipname;
            shipmentsize.Value = shipdata.ShipmentSize;
            shipmentdate.Value = shipdata.ShipmentDate;
            shipmentlocation.Value = shipdata.ShipmentLocation;
            shipmentstatus.Value = shipdata.ShipmentStatus;
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