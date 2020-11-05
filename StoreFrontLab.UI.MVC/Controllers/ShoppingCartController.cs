using Storefront.Data.EF;//Domain Models
using StoreFrontLab.UI.MVC.Models;//ShoppingCartViewModel
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreFrontLab.UI.MVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            var shoppingCart = (Dictionary<int, ShoppingCartViewModel>)Session["cart"];

            if (shoppingCart == null || shoppingCart.Count == 0)
            {
                shoppingCart = new Dictionary<int, ShoppingCartViewModel>();
                ViewBag.Message = "There are no shoes in your cart.";
            }
            //if the cart has something in it(!null) think return trips, null the message
            else
            {
                ViewBag.Message = null;
            }
            //Whether the cart has stuff or we send the empty instance - return the DICTIONARY bakck to the view
            return View(shoppingCart);

            //when adding the view select List Template, the ViewModel for the model and Clear out the 
            //Connection box, leave the last 2 options checked in the add view dialog, and click add
        }

        [HttpPost]
        public ActionResult AddToCart(int productID, int qty)
        {
            #region Care for 0 quantity in the update - Not covered in the QuickGuide
            //if they 0 the quantity and click update cart - remove the value from the cart (cover for negative values)
            if (qty <= 0)
            {
                RemoveFromCart(productID);
                return RedirectToAction("Index");
            }
            #endregion


            //retrieve the cart from session and assign it to a local dictionary
            Dictionary<int, ShoppingCartViewModel> shoppingCart = null;

            //Check the global shopping cart
            if (Session["cart"] != null)
            {
                shoppingCart = (Dictionary<int, ShoppingCartViewModel>)Session["cart"];
            }
            else
            {
                //create an empty local version
                shoppingCart = new Dictionary<int, ShoppingCartViewModel>();
            }

            //update the qty in local storage (dictionary)
            shoppingCart[productID].Qty = qty;

            //return the local cart to session
            Session["cart"] = shoppingCart;

            //if logic to prevent someone from zeroing out the quantity instead of removing from cart (messaging)
            if (shoppingCart.Count == 0)
            {
                ViewBag.Message = "There are no books in your cart.";
            }

            //return them to the index ACTION (re-run all logic in that method) - return the Index View with Updated
            //information
            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(int id)
        {
            //cart out of session and into the local
            Dictionary<int, ShoppingCartViewModel> shoppingCart =
                (Dictionary<int, ShoppingCartViewModel>)Session["cart"];

            //call the remove() from the Dictionary Class
            shoppingCart.Remove(id);

            //if shoppingcart count == 0 null the Session version of the cart
            if (shoppingCart.Count == 0)
            {
                Session["cart"] = null;
            }

            //return them to the index ACTION (re-run all logic in that method) - return the Index View with Updated
            //information
            return RedirectToAction("Index");
        }

    }
}