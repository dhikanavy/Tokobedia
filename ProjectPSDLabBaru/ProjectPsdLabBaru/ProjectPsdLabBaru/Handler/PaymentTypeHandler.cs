using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Repository;
using ProjectPsdLabBaru.Factory;

namespace ProjectPsdLabBaru.Handler
{
    public class PaymentTypeHandler
    {
        public static Boolean isPaymentTypeReferenced(int PaymentID)
        {
            HeaderTransaction ht = TransactionRepo.getHeaderTransactionByPaymentID(PaymentID);
            if (ht == null) return false;
            else return true;
        }
        public static List<PaymentType> getAll()
        {
            return PaymentTypeRepo.getAll();
        }
        public static Boolean getByID(int PaymentID)
        {
            if (PaymentTypeRepo.getByID(PaymentID) == null) return false;
            return true;
        }
        public static void add(String type)
        {
            PaymentTypeRepo.add(PaymentTypeFactory.createPaymentType(type));
        }
        public static void remove(int ID)
        {
            PaymentTypeRepo.remove(PaymentTypeRepo.get(ID));
        }

        public static void update(int ID, String type)
        {
            PaymentTypeRepo.update(ID, type);
        }

        public static Boolean checkPaymentTypeIsUnique(string Type)
        {
            PaymentType pt = PaymentTypeRepo.getByName(Type);
            if (pt != null) return false;
            else return true;
        }

        public static int getLastPaymentTypeID()
        {
            return PaymentTypeRepo.getLastPaymentTypeID();
        }
        public static String getName(int ID)
        {
            return PaymentTypeRepo.get(ID).Type;
        }
    }
}