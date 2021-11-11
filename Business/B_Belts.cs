using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Belts
    {
        static public void Save(BeltEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.Belts.Add(entity);
                db.SaveChanges();
            }
        }
        static public List<BeltEntity> GetAll()
        {
            using (var db = new DojangContext())
            {
                return db.Belts.ToList();
            }
        }
        static public BeltEntity GetById(int id)
        {
            using (var db = new DojangContext())
            {
                return db.Belts.ToList().FirstOrDefault(belt => belt.BeltID == id);
            }
        }
        static public void Update(BeltEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.Belts.Update(entity);
                db.SaveChanges();
            }
        }
        static public void Delete(int id)
        {
            using (var db = new DojangContext())
            {
                var StudentToDelete = db.Belts.ToList().FirstOrDefault(belt => belt.BeltID == id);
                if (StudentToDelete != null)
                {
                    StudentToDelete.Status = false;
                    db.Belts.Update(StudentToDelete);
                }
            }
        }
    }
}
