using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.Controller
{
    public class ProductTypeController
    {
        public static string delete(int ID)
        {
            string error = "";
            if(ProductTypeHandler.isProductTypeReferenced(ID))
            {
                error = "Failed to delete selected product type";
            }
            return error;
        }
        public static string insert(string Name, string Description)
        {
            string error="";
            if (Name == "")
            {
                error = "Product type name must be filled";
            }
            else if (Description == "")
            {
                error = "Description must be filled";
            }
            else if (Name.Length < 5)
            {
                error = "Product type name must be consists of 5 characters or more";
            }
            else if (!ProductTypeHandler.checkProductTypeIsUnique(Name))
            {
                error = "Product type name must be unique";
            }
            return error;
        }
        public static string update(string Name, string Description)
        {
            string error = "";
            if (Name == "")
            {
                error = "Product type name must be filled";
            }
            else if (Description == "")
            {
                error = "Description must be filled";
            }
            else if (Name.Length < 5)
            {
                error = "Product type name must be consists of 5 characters or more";
            }
            else if (!ProductTypeHandler.checkProductTypeIsUnique(Name))
            {
                error = "Product type name must be unique";
            }
            return error;
        }
    }
}