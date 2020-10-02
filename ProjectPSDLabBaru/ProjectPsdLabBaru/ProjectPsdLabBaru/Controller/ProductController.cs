using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.Controller
{
    public class ProductController
    {
        public static string insert(string name, string stock, string price, string productTypeID)
        {
            string error = "";
            int stockProduct, priceProduct, currentProductTypeID;
            bool flag = true;
            try
            {
                stockProduct = int.Parse(stock);
                priceProduct = int.Parse(price);
                currentProductTypeID = int.Parse(productTypeID);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    flag = false;
                    error = "Input stock, product type, and price must be a number";
                }
            }
            if (flag)
            {
                if (name == "")
                {
                    error = "Product name must be filled";
                }
                else if (int.Parse(stock) < 1)
                {
                    error = "Stock must be 1 or more";
                }
                else if (int.Parse(price) <= 1000)
                {
                    error = "Product price must be more than 1000";
                }
                else if (int.Parse(price) % 1000 != 0)
                {
                    error = "Product price must be multiply of 1000";
                }
                else if (!ProductTypeHandler.checkIfInsertedProductTypeIDValid(int.Parse(productTypeID)))
                {
                    error = "Product type id is invalid";
                }
            }
            return error;
        }
        public static string update(string name, string stock, string price)
        {
            string error = "";
            int stockProduct, priceProduct;
            bool flag = true;
            try
            {
                stockProduct = int.Parse(stock);
                priceProduct = int.Parse(price);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    flag = false;
                    error = "Input stock and price must be a number";
                }
            }
            if (flag)
            {
                if (name == "")
                {
                    error = "Product name must be filled";
                }
                else if (int.Parse(stock) < 1)
                {
                    error = "Stock must be 1 or more";
                }
                else if (int.Parse(price) <= 1000)
                {
                    error = "Product price must be more than 1000";
                }
                else if (int.Parse(price) % 1000 != 0)
                {
                    error = "Product price must be multiply of 1000";
                }
            }
            return error;
        }
    }
}