using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Repository;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Factory;

namespace ProjectPsdLabBaru.Handler
{
    public class ProductHandler
    {
        public static Product get(int ID)
        {
            return ProductRepo.get(ID);

        }
        public static String getName(int ID)
        {
            Product p = ProductRepo.get(ID);
            return p.Name;
        }
        public static int getPrice(int ID)
        {
            Product p = ProductRepo.get(ID);
            return p.Price;
        }
        public static int getStock(int ID)
        {
            Product p = ProductRepo.get(ID);
            return p.Stock;
        }
        public static int getLastProductID()
        {
            return ProductRepo.getLastProductID();
        }
        public static void insertProduct(String Name, int Price, int Stock, int ProductTypeID)
        {
            ProductRepo.insertProduct(ProductFactory.createProduct(Name, Price, Stock, ProductTypeID));
        }
        public static void updateProduct(int ID, String Name, int Price, int Stock)
        {
            ProductRepo.updateProduct(ID, Name, Price, Stock);
        }
        public static void updateProductStock(int ProductID, int CheckOutQuantity)
        {
            ProductRepo.updateProductStock(ProductID, CheckOutQuantity);
        }
        public static List<Product> getAllProduct()
        {
            return ProductRepo.getAllProduct();
        }
        public static List<Product> getFiveRandomProduct()
        {
            var ListAllProduct = getAllProduct();
            var ListFiveRandomProduct = new List<Product>();
            Random rand = new Random();
            int random=0;
            for(int i=0; i<5; i++)
            {
                if (ListAllProduct.Count() > 0)
                {
                    random = rand.Next(ListAllProduct.Count());
                    if (ListAllProduct[random] != null)
                    {
                        ListFiveRandomProduct.Add(ListAllProduct[random]);
                        ListAllProduct.Remove(ListAllProduct[random]);
                    }
                }
            }
            return ListFiveRandomProduct;
        }
    }
}