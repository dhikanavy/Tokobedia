using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;
using ProjectPsdLabBaru.Constant;

namespace ProjectPsdLabBaru.Repository
{
    public class CartRepo
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static List<Cart> getTotalQuantity()
        {
            return db.Carts.ToList();
        }
        public static void add(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }
        public static void remove(Cart cart)
        {
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
        public static void update(int UserID, int ProductID, int Quantity)
        {
            Cart cart = (from x in db.Carts
                             where x.UserID == UserID && x.ProductID == ProductID
                             select x).FirstOrDefault();
            cart.Quantity += Quantity;
            db.SaveChanges();
        }
        public static void updateNewQuantity(int UserID, int ProductID, int Quantity)
        {
            Cart cart = (from x in db.Carts
                         where x.UserID == UserID && x.ProductID == ProductID
                         select x).FirstOrDefault();
            cart.Quantity = Quantity;
            db.SaveChanges();
        }
        public static List<Cart> getCartCustomView(int UserID)
        {
            var CartInformation_List = (from x in db.Carts
                                        where x.UserID == UserID
                                        select x).ToList();
           
            return CartInformation_List;
        }
        public static Cart get(int UserID, int ProductID)
        {
            Cart cart = (from x in db.Carts
                         where x.UserID == UserID && x.ProductID == ProductID
                         select x).FirstOrDefault();

            return cart;
        }
        public static List<Cart> getAll()
        {
            return db.Carts.ToList();
        }
    }
}