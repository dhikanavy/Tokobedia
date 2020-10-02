using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.Factory
{
    public class TransactionFactory
    {
        public static HeaderTransaction createHeaderTransaction(int UserID, int PaymentTypeID)
        {
            HeaderTransaction ht = new HeaderTransaction();
            ht.ID = TransactionHandler.getLastTransactionID() + 1;
            ht.UserID = UserID;
            ht.PaymentTypeID = PaymentTypeID;
            ht.Date = DateTime.Now;
            return ht;
        }
        public static DetailTransaction createDetailTransaction(int TransactionID, int ProductID, int Quantity)
        {
            DetailTransaction dt = new DetailTransaction();
            dt.TransactionID = TransactionID;
            dt.ProductID = ProductID;
            dt.Quantity = Quantity;
            return dt;
        }
    }
}