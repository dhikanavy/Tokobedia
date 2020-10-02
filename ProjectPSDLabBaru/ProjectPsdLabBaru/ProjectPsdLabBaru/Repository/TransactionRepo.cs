using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Repository;

namespace ProjectPsdLabBaru.Repository
{
    public class TransactionRepo
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static int getLastTransactionID()
        {
            if (db.HeaderTransactions.ToList().Count == 0) return 0;
            HeaderTransaction ht = db.HeaderTransactions.ToList().LastOrDefault();
            return ht.ID;
        }
        public static void addHeaderTransaction(HeaderTransaction headerTransaction)
        {
            db.HeaderTransactions.Add(headerTransaction);
            db.SaveChanges();
        }
        public static void addDetailTransaction(DetailTransaction detailTransaction)
        {
            db.DetailTransactions.Add(detailTransaction);
            db.SaveChanges();
        }
        public static HeaderTransaction getHeaderTransactionByPaymentID(int PaymentID)
        {
            HeaderTransaction ht = db.HeaderTransactions.Where(hts =>
                    hts.PaymentTypeID == PaymentID
                )
                .FirstOrDefault();

            return ht;
        }
    }
}