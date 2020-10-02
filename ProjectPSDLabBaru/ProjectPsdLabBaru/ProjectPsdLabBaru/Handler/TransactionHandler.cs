using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Repository;
using ProjectPsdLabBaru.Factory;

namespace ProjectPsdLabBaru.Handler
{
    public class TransactionHandler
    {
        public static void insertTransaction(List<Cart> carts, int paymentTypeID, int UserID)
        {
            TransactionRepo.addHeaderTransaction(TransactionFactory.createHeaderTransaction(UserID, paymentTypeID));
            int transactionId = TransactionRepo.getLastTransactionID();
            for (int i = 0; i < carts.Count; i++)
            {
                Product product = ProductHandler.get(carts[i].ProductID);
                if (carts[i].Quantity <= product.Stock)
                {
                    ProductHandler.updateProductStock(carts[i].ProductID, carts[i].Quantity);
                    TransactionRepo.addDetailTransaction(TransactionFactory.createDetailTransaction(transactionId, carts[i].ProductID, carts[i].Quantity));
                }
            }
        }
        public static int getLastTransactionID()
        {
            return TransactionRepo.getLastTransactionID();
        }
    }
}