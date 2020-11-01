using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreFrontLab.UI.MVC.Models
{
    public class ProductsViewModel
    {
        public int ProductID { get; set; }

        public string ShoeImage { get; set; }

        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }


    }
}