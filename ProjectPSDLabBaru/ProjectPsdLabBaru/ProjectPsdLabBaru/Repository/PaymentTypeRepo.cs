using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectPsdLabBaru.Model;

namespace ProjectPsdLabBaru.Repository
{
    public class PaymentTypeRepo
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static List<PaymentType> getAll()
        {
            return db.PaymentTypes.ToList();
        }
        public static PaymentType getByID(int PaymentID)
        {
            PaymentType pType = db.PaymentTypes.Where(p =>
                    p.ID == PaymentID
                )
                .FirstOrDefault();

            return pType;
        }
        public static void add(PaymentType pt)
        {
            db.PaymentTypes.Add(pt);
            db.SaveChanges();
        }
        public static void remove(PaymentType pt)
        {
            db.PaymentTypes.Remove(pt);
            db.SaveChanges();
        }
        public static void update(int ID, String type)
        {
            PaymentType pt = (from x in db.PaymentTypes
                              where x.ID == ID
                              select x).FirstOrDefault();

            pt.Type = type;
            db.SaveChanges();
        }
        public static PaymentType get(int ID)
        {
            PaymentType pt = (from x in db.PaymentTypes
                              where x.ID == ID
                              select x).FirstOrDefault();

            return pt;
        }
        public static PaymentType getByName(string type)
        {
            PaymentType pt = db.PaymentTypes.Where(pts =>
                    pts.Type == type
                )
                .FirstOrDefault();
            return pt;
        }
        public static void updatePaymentType(int ID, String type)
        {
            PaymentType paymentType = db.PaymentTypes.Where(pts =>
                    pts.ID == ID
                )
                .FirstOrDefault();

            paymentType.Type = type;
            db.SaveChanges();
        }
        public static int getLastPaymentTypeID()
        {
            if (db.PaymentTypes.ToList().Count == 0) return 0;
            PaymentType paymentType = db.PaymentTypes.ToList().LastOrDefault();
            return paymentType.ID;
        }
    }
}