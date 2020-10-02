using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.Factory
{
    public class ProductFactory
    {
        public static Product createProduct(String name, int price, int stock, int productTypeID)
        {
            Product product = new Product();
            product.ID = ProductHandler.getLastProductID() + 1;
            product.ProductTypeID = productTypeID;
            product.Name = name;
            product.Price = price;
            product.Stock = stock;
            return product;
        }
    }
}