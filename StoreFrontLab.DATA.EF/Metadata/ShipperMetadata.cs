using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontLab.DATA.EF
{
    public class ShipperMetadata
    {
        [Display(Name = "Company Name")]
        [StringLength(40)]
        [Required]
        public string CompanyName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

    }

    [MetadataType(typeof(ShipperMetadata))]
    public partial class Shipper
    {

    }
}
