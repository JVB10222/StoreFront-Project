using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontLab.DATA.EF
{
    public class CustomerMetadata
    {
        [Display(Name = "Company Name")]
        [StringLength(40)]
        [Required]
        public string CompanyName { get; set; }

        [Display(Name = "Contact Name")]
        [StringLength(30)]
        public string ContactName { get; set; }

        [Display(Name = "Contact Title")]
        [StringLength(30)]
        public string ContactTitle { get; set; }

        [StringLength(60)]
        [UIHint("MultilineText")]
        public string Address { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        [StringLength(10)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [StringLength(15)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [StringLength(24)]
        public string Fax { get; set; }


    }

    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer
    {

    }
}
