using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Models;

namespace CMS
{
    public partial class Add_Info : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void addRecord(object sender, EventArgs e) {
            //System.Diagnostics.Debug.WriteLine(shipname.Value);

            var newshipinfo = new ShipmentActivity
            {
                Shipname = shipname.Value,
                ShipmentSize = shipmentsize.Value,
                ShipmentDate = shipmentdate.Value,
                ShipmentLocation = shipmentlocation.Value,
                ShipmentStatus = shipmentstatus.Value
            };

            var db = new ShipmentActivityContext();
            db.ShipmentActivities.Add(newshipinfo);
            db.SaveChanges();

            Response.Redirect(Request.RawUrl);
        }
    }
}