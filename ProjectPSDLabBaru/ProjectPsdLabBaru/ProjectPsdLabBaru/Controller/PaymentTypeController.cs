using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.Controller
{
    public class PaymentTypeController
    {
        public static string delete(int ID)
        {
            string error = "";
            if (PaymentTypeHandler.isPaymentTypeReferenced(ID))
            {
                error = "Failed to delete selected payment type";
            }
            return error;
        }
        public static string insert(String type)
        {
            string error = "";
            String tipe = type;

            if (tipe == "")
            {
                error = "Payment Type name must be filled";
            }
            else if (tipe.Length < 3)
            {
                error = "Payment type name must be consists of 3 characters or more";
            }
            else if (!PaymentTypeHandler.checkPaymentTypeIsUnique(tipe))
            {
                error = "Product type name must be unique";
            }
                
            return error;
        }

        public static string update(String type)
        {
            string error = "";
            String tipe = type;
            if (tipe == "")
            {
                error = "Payment Type name must be filled";
            }
            else if (tipe.Length < 3)
            {
                error = "Payment type name must be consists of 3 characters or more";
            }
            else if (!PaymentTypeHandler.checkPaymentTypeIsUnique(tipe))
            {
                error = "Product type name must be unique";
            }
            return error;
        }
    }
}