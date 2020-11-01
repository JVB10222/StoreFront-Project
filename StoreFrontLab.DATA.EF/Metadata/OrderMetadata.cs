using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontLab.DATA.EF
{
    public class OrderMetadata
    {

        [Display(Name = "Order Date")]
        public DateTime? OrderDate { get; set; }

        [Display(Name = "Required Date")]
        public DateTime? RequiredDate { get; set; }

        [Display(Name = "Shipped Date")]
        public DateTime? ShippedDate { get; set; }

        public int? ShipVia { get; set; }

        public decimal? Freight { get; set; }

        public string ShipName { get; set; }

        [Display(Name = "Ship Address")]
        public string ShipAddress { get; set; }

        [Display(Name = "Ship City")]
        public string ShipCity { get; set; }

        [Display(Name = "Ship Region")]
        public string ShipRegion { get; set; }

        [Display(Name = "Ship Postal Code")]
        public string ShipPostalCode { get; set; }

        [Display(Name = "Ship Country")]
        public string ShipCountry { get; set; }

    }

    [MetadataType(typeof(OrderMetadata))]
    public partial class Order
    {

    }
}
