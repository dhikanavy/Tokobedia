using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.Factory
{
    public class PaymentTypeFactory
    {
        public static PaymentType createPaymentType(String type)
        {
            PaymentType pt = new PaymentType();
            pt.ID = PaymentTypeHandler.getLastPaymentTypeID() + 1;
            pt.Type = type;
            return pt;
        }
    }
}