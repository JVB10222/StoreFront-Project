using System.Web.Mvc;
//using StoreFrontLab.DATA.EF;
using Storefront.Data.EF;
using PagedList;
using PagedList.Mvc;
using System.Data.Entity;
using System.Web;
using System.Linq;
using StoreFrontLab.UI.MVC.Models   ;
using System.Collections.Generic;

namespace StoreFrontLab.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //[Authorize]
        private StoreFront2Entities db = new StoreFront2Entities();


        //comeback to this^


        public ActionResult Products(int page = 1)
        {
            int pageSize = 6;

            var shoes = db.Products.Select(b => new { b.ProductID,b.ShoeImage,b.ProductName, b.UnitPrice}).ToList();

            List<ProductsViewModel> ProductVM = new List<ProductsViewModel>();

            foreach (var product in shoes)
            {
                ProductsViewModel shoe = new ProductsViewModel();

                shoe.ProductID = product.ProductID;
                shoe.ShoeImage = product.ShoeImage;
                shoe.ProductName = product.ProductName;
                shoe.UnitPrice = product.UnitPrice;

                ProductVM.Add(shoe);
            }


            return View(ProductVM.ToPagedList(page, pageSize));
        }

        [HttpGet]
        public ActionResult Cart()
        {
            
            return View();
        }
    }
}
