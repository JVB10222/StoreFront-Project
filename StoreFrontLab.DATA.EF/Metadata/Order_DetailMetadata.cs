using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontLab.DATA.EF
{
    public class Order_DetailMetadata
    {
        [Required]
        [Display(Name = "Unit Price")]
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public decimal UnitPrice { get; set; }
    }

    [MetadataType(typeof(Order_DetailMetadata))]
    public partial class Order_Detail
    {

    }
}
