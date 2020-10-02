using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;

namespace ProjectPsdLabBaru.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int UserID, int ProductID, int Quantity)
        {
            Cart cart = new Cart();
            cart.UserID = UserID;
            cart.ProductID = ProductID;
            cart.Quantity = Quantity;
            return cart;
        }
    }
}