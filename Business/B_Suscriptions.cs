using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Suscriptions
    {
        public void Save(SuscriptionEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.Suscriptions.Add(entity);
                db.SaveChanges();
            }
        }
        public List<SuscriptionEntity> GetAll()
        {
            using (var db = new DojangContext())
            {
                return db.Suscriptions.ToList();
            }
        }
        public SuscriptionEntity GetById(int id)
        {
            using (var db = new DojangContext())
            {
                return db.Suscriptions.ToList().FirstOrDefault(suscription => suscription.SuscriptionID == id);
            }
        }
        public void Update(SuscriptionEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.Suscriptions.Update(entity);
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var db = new DojangContext())
            {
                var StudentToDelete = db.Suscriptions.ToList().FirstOrDefault(suscription => suscription.SuscriptionID == id);
                if (StudentToDelete != null)
                {
                    StudentToDelete.Status = false;
                    db.Suscriptions.Update(StudentToDelete);
                }
            }
        }
    }
}
