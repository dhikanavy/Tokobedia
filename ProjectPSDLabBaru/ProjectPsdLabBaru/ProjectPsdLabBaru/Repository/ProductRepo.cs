using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;

namespace ProjectPsdLabBaru.Repository
{
    public class ProductRepo
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static void updateProductStock(int ProductID, int CheckOutQuantity)
        {
            Product productInfo = db.Products.Where(p =>
                    p.ID == ProductID
                )
                .FirstOrDefault();
            
            productInfo.Stock -= CheckOutQuantity;
            db.SaveChanges();
        }
        public static int getLastProductID()
        {
            if (db.Products.ToList().Count == 0) return 0;
            Product product = db.Products.ToList().LastOrDefault();
            return product.ID;
        }
        public static void insertProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        public static void updateProduct(int ID, String Name, int Price, int Stock)
        {
            Product productInfo = db.Products.Where(p =>
                    p.ID == ID
                )
                .FirstOrDefault();

            productInfo.Name = Name;
            productInfo.Price = Price;
            productInfo.Stock = Stock;
            db.SaveChanges();
        }
        public static List<Product> getAllProduct()
        {
            return db.Products.ToList();
        }
        public static Product get(int ID)
        {
            Product product = db.Products.Where(p =>
                    p.ID == ID
                )
                .FirstOrDefault();

            return product;
        }
        public static Product getByProductTypeID(int ProductTypeID)
        {
            Product product = db.Products.Where(p =>
                    p.ProductTypeID == ProductTypeID
                )
                .FirstOrDefault();

            return product;
        }
    }
}