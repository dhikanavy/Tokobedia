using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.Controller
{
    public class CartController
    {
        public static String checkPaymentTypes(String PaymentTypeID)
        {
            string error = "";
            int PaymentID = 0;
            bool flag = true;
            try
            {
                PaymentID = int.Parse(PaymentTypeID);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    flag = false;
                    error = "Input Payment Type ID must be a number";
                }
            }
            if (flag)
            {
                if (!PaymentTypeHandler.getByID(int.Parse(PaymentTypeID)))
                {
                    error = "Payment Type ID is invalid";
                }
            }
            return error;
        }
        public static String update(String Quantity, int ID, int UserID)
        {
            string error = "";
            int QuantityProduct = 0;
            bool flag = true;
            try
            {
                QuantityProduct = int.Parse(Quantity);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    flag = false;
                    error = "Input quantity must be a number";
                }
            }
            if (flag)
            {
                if (int.Parse(Quantity) < 0)
                {
                    error = "Quantity cannot be less than 0";
                }
                else if (int.Parse(Quantity) > ProductHandler.getStock(ID))
                {
                    error = "Quantity must be less than or equals to current stock";
                }
                else if (int.Parse(Quantity) + CartHandler.getTotalQuantity(ID, UserID) > ProductHandler.getStock(ID))
                {
                    error = "The inputted quantity and the reserved quantity in other carts combined altogether must not exceed the selected product’s current stock";
                }
            }
            return error;
        }
        public static string Add(String Quantity, int ID)
        {
            string error = "";
            int QuantityProduct=0;
            bool flag = true;
            try
            {
                QuantityProduct = int.Parse(Quantity);
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    flag = false;
                    error = "Input quantity must be a number";
                }
            }
            if (flag)
            {
                if (int.Parse(Quantity) <= 0)
                {
                    error = "Quantity must be more than 0";
                }
                else if (int.Parse(Quantity) > ProductHandler.getStock(ID))
                {
                    error = "Quantity must be less than or equals to current stock";
                }
                else if (int.Parse(Quantity) + CartHandler.getTotalQuantity(ID) > ProductHandler.getStock(ID))
                {
                    error = "The inputted quantity and the reserved quantity in other carts combined altogether must not exceed the selected product’s current stock";
                }
            }
            return error;
        }
    }
}