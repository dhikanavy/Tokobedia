using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Repository;
using ProjectPsdLabBaru.Factory;
namespace ProjectPsdLabBaru.Handler
{
    public class ProductTypeHandler
    {
        public static List<ProductType> getAllProductType()
        {
            return ProductTypeRepo.getAllProductType();
        }
        public static Boolean checkIfInsertedProductTypeIDValid(int ID)
        {
            ProductType pt = ProductTypeRepo.get(ID);
            if (pt == null) return false;
            else return true;
        }
        public static Boolean checkIfProductTypeIDValid(int ID)
        {
            ProductType pt = ProductTypeRepo.get(ID);
            Product product = ProductRepo.getByProductTypeID(ID);
            if (pt == null || product != null) return false;
            else return true;
        }
        public static Boolean checkProductTypeIsUnique(string Name)
        {
            ProductType pt = ProductTypeRepo.getByName(Name);
            if (pt != null) return false;
            else return true;
        }
        public static Boolean isProductTypeReferenced(int ProductTypeID)
        {
            Product product = ProductRepo.getByProductTypeID(ProductTypeID);
            if (product == null) return false;
            else return true;
        }
        public static void remove(int ID)
        {
            ProductTypeRepo.remove(ProductTypeRepo.get(ID));
        }
        public static int getLastProductTypeID()
        {
            return ProductTypeRepo.getLastProductTypeID();
        }
        public static void insertProductType(String Name, String Description)
        {
            ProductTypeRepo.insertProductType(ProductTypeFactory.createProductType(Name, Description));
        }
        public static ProductType get(int ID)
        {
            return ProductTypeRepo.get(ID);
        }
        public static void updateProductType(int ID, String Name, String Description)
        {
            ProductTypeRepo.updateProductType(ID, Name, Description);
        }
        public static string getProductType(int ID)
        {
            ProductType pt = ProductTypeRepo.getProductType(ID);
            return pt.Name;
        }
    }
}