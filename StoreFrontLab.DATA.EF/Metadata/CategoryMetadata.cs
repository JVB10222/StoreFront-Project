using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontLab.DATA.EF
{
    public class CategoryMetadata
    {
        [Required]
        [StringLength(15)]
        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }

        [UIHint("MultilineText")]
        public string Description { get; set; }


    }

    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {

    }
}
