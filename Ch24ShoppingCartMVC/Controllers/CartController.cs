using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ch24ShoppingCartMVC.Models;

namespace Ch24ShoppingCartMVC.Controllers {
    public class CartController : Controller
    {
        private CartModel cart = new CartModel();

        [HttpGet]
        public RedirectToRouteResult Index()
        {
            return RedirectToAction("List");
        }
        [HttpGet]
        public ViewResult List()
        {
            CartViewModel model = (CartViewModel)TempData["cart"];
            //if the model is null, then call the method GetCart
            if(model == null)
            {
                model = cart.GetCart();
            }
            //Passing model to View
            return View(model);
        }
        [HttpPost]
        public RedirectToRouteResult List(OrderViewModel order)
        {
            CartViewModel model = cart.GetCart(order.SelectedProduct.ProductID);
            //Assign the quantity of the selected product to the quantity of the added product
            model.AddedProduct.Quantity = order.SelectedProduct.Quantity;
            //Call the method AddtoCart
            cart.AddToCart(model);
            //Assign model to the TempData
            TempData["model"] = model;
            return RedirectToAction("List", "Cart");
        }

        [HttpGet]
        public ActionResult Checkout()
        {
            CartViewModel itemList = (CartViewModel)TempData["model"];
            if (itemList == null)
            {
                itemList = cart.GetCart();
            }
            decimal sum = itemList.Cart.Sum(x => x.Quantity * x.UnitPrice);
            decimal sumTax = sum + ((decimal)0.05*sum);
            ViewData["Total"] = sum;
            ViewData["Total With Tax"] = sumTax;
            return View(itemList);
        }
    }
}
