using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_PaymentHistory
    {
        static public void Save(PaymentHistoryEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.PaymentHistory.Add(entity);
                db.SaveChanges();
            }
        }
        static public List<PaymentHistoryEntity> GetAll()
        {
            using (var db = new DojangContext())
            {
                return db.PaymentHistory.ToList();
            }
        }
        static public PaymentHistoryEntity GetById(int id)
        {
            using (var db = new DojangContext())
            {
                return db.PaymentHistory.ToList().FirstOrDefault(suscription => suscription.PaymentID == id);
            }
        }
        static public void Update(PaymentHistoryEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.PaymentHistory.Update(entity);
                db.SaveChanges();
            }
        }
        static public void Delete(int id)
        {
            using (var db = new DojangContext())
            {
                var PaymentToDelete = db.PaymentHistory.ToList().FirstOrDefault(suscription => suscription.PaymentID == id);
                if (PaymentToDelete != null)
                {
                    PaymentToDelete.Status = false;
                    db.PaymentHistory.Update(PaymentToDelete);
                }
            }
        }
    }
}
