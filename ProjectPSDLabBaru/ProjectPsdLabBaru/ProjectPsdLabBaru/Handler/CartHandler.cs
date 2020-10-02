using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Repository;
using ProjectPsdLabBaru.Factory;
using ProjectPsdLabBaru.Constant;
using ProjectPsdLabBaru.Model;

namespace ProjectPsdLabBaru.Handler
{
    public class CartHandler
    {
        public static void removeAll(int UserID)
        {
            var listAll = getAll();
            for (int i=0; i<listAll.Count; i++)
            {
                if (listAll[i].UserID == UserID) CartRepo.remove(listAll[i]);
            }
        }
        public static List<Cart> getAll()
        {
            return CartRepo.getAll();
        }
        public static List<Cart> getAllCurrentUserCart(int UserID)
        {
            return CartRepo.getCartCustomView(UserID);
        }
        public static int getTotalQuantity(int ID, int UserID)
        {
            var Cart_List = CartRepo.getTotalQuantity();
            int totalQuantity = 0;
            for (int i = 0; i < Cart_List.Count(); i++)
            {
                if (Cart_List[i].ProductID == ID && Cart_List[i].UserID != UserID) totalQuantity += Cart_List[i].Quantity;
            }
            return totalQuantity;
        }
        public static int getTotalQuantity(int ID)
        {
            var Cart_List =  CartRepo.getTotalQuantity();
            int totalQuantity=0;
            for (int i = 0; i < Cart_List.Count(); i++)
            {
                if(Cart_List[i].ProductID == ID) totalQuantity += Cart_List[i].Quantity;
            }
            return totalQuantity;
        }
        public static void add(int UserID, int ProductID, int Quantity)
        {
            CartRepo.add(CartFactory.createCart(UserID, ProductID, Quantity));
        }
        public static void remove(int UserID, int ProductID)
        {
            CartRepo.remove(CartRepo.get(UserID, ProductID));
        }
        public static Cart get(int UserID, int ProductID)
        {
            return CartRepo.get(UserID, ProductID);
        }
        public static void updateQuantity(int UserID, int ProductID, int Quantity)
        {
            CartRepo.update(UserID, ProductID, Quantity);
        }
        public static void updateNewQuantity(int UserID, int ProductID, int Quantity)
        {
            CartRepo.updateNewQuantity(UserID, ProductID, Quantity);
        }
        public static int getQuantity(int UserID, int ProductID)
        {
            Cart cart = CartRepo.get(UserID, ProductID);
            return cart.Quantity;
        }
        public static Boolean getProduct(int UserID, int ProductID)
        {
            Cart cart = CartRepo.get(UserID, ProductID);
            if (cart == null) return false;
            else return true;
        }
        public static List<CartInformation> getCartCustomView(int UserID)
        {
            var cart_List =  CartRepo.getCartCustomView(UserID);
            var cartInformation_List = new List<CartInformation>();
            for(int i=0; i<cart_List.Count; i++)
            {
                CartInformation CInfo = new CartInformation();
                CInfo.ID = cart_List[i].ProductID;
                CInfo.Name = ProductHandler.getName(cart_List[i].ProductID);
                CInfo.Price = ProductHandler.getPrice(cart_List[i].ProductID);
                CInfo.Quantity = getQuantity(UserID, cart_List[i].ProductID);
                CInfo.SubTotal = (ProductHandler.getPrice(cart_List[i].ProductID) * cart_List[i].Quantity);
                cartInformation_List.Add(CInfo);
            }
            return cartInformation_List;
        }
    }
}