using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ch24ShoppingCartMVC.Models;

namespace Ch24ShoppingCartMVC.Models{
    public class CartModel
    {
        //Data Access methods 
        /* private List<ProductViewModel> GetCartFromDataStore()
         {
             List<ProductViewModel> cart;
             object objCart = HttpContext.Current.Session["cart"];
             //Convert objCart to List<ProductViewModel>
             ________________________________
             if (cart == null)
             {   //Create the object cart
                 __________________________________
                 //Assign cart to the Session object cart
                 ____________________________________________
             }
             return cart;
         }
         private ProductViewModel GetSelectedProduct(string id)
         {   //Create an OrderModel object called order
             _______________________________
             //Call the method GetSelectedProduct of the class OrderModel. Return the object returned by the call.
             return _____________________________________
         }
         public CartViewModel GetCart(string id = "")
         {
             CartViewModel model = new CartViewModel();
             //Call the method GetCartFromDataStore
             ____________________________________
             if (!string.IsNullOrEmpty(id))
                 //Called the method GetSelectedProduct with parameter id and assign the return object to the AddedProduct
                 ____________________________________________
             return model;
         }
         private void AddItemToDataStore(CartViewModel model)
         {   //Add the AddedProduct to the cart
             __________________________________________
         }
         public void AddToCart(CartViewModel model)
         {
             if (model.AddedProduct.ProductID != null)
             {
                 //Get the product id of the added product
                 ______________________________________________
                 //Find the product in the car that matches the id using lambda expression.
                 __________________________________________
                 if (inCart == null)
                     //Call the method AddItemToDataStore
                     _________________________________________
                 else
                     //Increase the Quantity by the quantity of the added product
                     ________________________________________
             }
         }

        */
    }
}