using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontLab.DATA.EF
{
    public class EmployeeMetadata
    {
        [Required]
        [StringLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(25)]
        [Display(Name = "Title of Courtesy")]
        public string TitleOfCourtesy { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Hire Date")]
        public DateTime? HireDate { get; set; }

        [StringLength(60)]
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
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [StringLength(4)]
        public string Extension { get; set; }

        [UIHint("MultelineText")]
        public string Notes { get; set; }

        [Display(Name = "Reports To")]
        public int? ReportsTo { get; set; }

    }


    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {

    }
}
