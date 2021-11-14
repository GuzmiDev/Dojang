using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_PaymentPlan
    {
        static public void Save(PaymentPlanEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.PaymentPlan.Add(entity);
                db.SaveChanges();
            }
        }
        static public List<PaymentPlanEntity> GetAll()
        {
            using (var db = new DojangContext())
            {
                return db.PaymentPlan.ToList();
            }
        }
        static public PaymentPlanEntity GetById(int id)
        {
            using (var db = new DojangContext())
            {
                return db.PaymentPlan.ToList().FirstOrDefault(suscription => suscription.PaymentPlanID== id);
            }
        }
        static public void Update(PaymentPlanEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.PaymentPlan.Update(entity);
                db.SaveChanges();
            }
        }
        static public void Delete(int id)
        {
            using (var db = new DojangContext())
            {
                var PlanToDelete = db.PaymentPlan.ToList().FirstOrDefault(suscription => suscription.PaymentPlanID == id);
                if (PlanToDelete != null)
                {
                    PlanToDelete.Status = false;
                    db.PaymentPlan.Update(PlanToDelete);
                }
            }
        }
    }
}
