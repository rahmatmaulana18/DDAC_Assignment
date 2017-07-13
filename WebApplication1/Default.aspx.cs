using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Models;

namespace CMS
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new ShipmentActivityContext();
            IQueryable<ShipmentActivity> query = db.ShipmentActivities;
            List<ShipmentActivity> shipmentlist = query.ToList();
        }
    }
}