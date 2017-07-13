using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public class ShipmentActivity
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ShipmentID { get; set; }

        public string Shipname { get; set; }

        public string ShipmentSize { get; set; }

        public string ShipmentDate { get; set; }

        public string ShipmentLocation { get; set; }

        public string ShipmentStatus { get; set; }
    }

}