using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.Factory
{
    public class ProductTypeFactory
    {
        public static ProductType createProductType(String name, String description)
        {
            ProductType productType = new ProductType();
            productType.ID = ProductTypeHandler.getLastProductTypeID() + 1;
            productType.Name = name;
            productType.Description = description;
            return productType;
        }
    }
}