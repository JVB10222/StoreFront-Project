using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontLab.DATA.EF
{
    public class ProductMetadata
    {
        public int ProductID { get; set; }

        [Display(Name = "Cover")]
        public string ShoeImage { get; set; }


        [Display(Name = "Product Name")]
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:c}", NullDisplayText = "[-Price Not Given-]")]
        public Nullable<decimal> UnitPrice { get; set; }

        [Display(Name ="Description")]
        public string Description { get; set; }


    }

    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {

    }
}
