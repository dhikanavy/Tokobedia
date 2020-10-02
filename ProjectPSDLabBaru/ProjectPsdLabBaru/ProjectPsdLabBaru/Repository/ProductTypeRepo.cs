using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;

namespace ProjectPsdLabBaru.Repository
{
    public class ProductTypeRepo
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static ProductType get(int ID)
        {
            ProductType pt = db.ProductTypes.Where(pts =>
                    pts.ID == ID
                )
                .FirstOrDefault();
            return pt;
        }
        public static List<ProductType> getAllProductType()
        {
            return db.ProductTypes.ToList();
        }
        public static ProductType getProductType(int ID)
        {
            ProductType pt = db.ProductTypes.Where(pts =>
                    pts.ID == ID
                )
                .FirstOrDefault();
            return pt;
        }
        public static void remove(ProductType productType)
        {
            db.ProductTypes.Remove(productType);
            db.SaveChanges();
        }
        public static ProductType getByName(string Name)
        {
            ProductType pt = db.ProductTypes.Where(pts =>
                    pts.Name == Name
                )
                .FirstOrDefault();
            return pt;
        }
        public static int getLastProductTypeID()
        {
            if (db.ProductTypes.ToList().Count == 0) return 0;
            ProductType productType = db.ProductTypes.ToList().LastOrDefault();
            return productType.ID;
        }
        public static void insertProductType(ProductType productType)
        {
            db.ProductTypes.Add(productType);
            db.SaveChanges();
        }
        public static void updateProductType(int ID, String Name, String Description)
        {
            ProductType productTypeInfo = db.ProductTypes.Where(pts =>
                    pts.ID == ID
                )
                .FirstOrDefault();

            productTypeInfo.Name = Name;
            productTypeInfo.Description = Description;
            db.SaveChanges();
        }
    }
}