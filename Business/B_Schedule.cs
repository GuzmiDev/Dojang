using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Schedule
    {
        static public void Save(ScheduleEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.Schedules.Add(entity);
                db.SaveChanges();
            }
        }
        static public List<ScheduleEntity> GetAll()
        {
            using (var db = new DojangContext())
            {
                return db.Schedules.ToList();
            }
        }
        static public ScheduleEntity GetById(int id)
        {
            using (var db = new DojangContext())
            {
                return db.Schedules.ToList().FirstOrDefault(schedule => schedule.ScheduleID == id);
            }
        }
        static public void Update(ScheduleEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.Schedules.Update(entity);
                db.SaveChanges();
            }
        }
        static public void Delete(int id)
        {
            using (var db = new DojangContext())
            {
                var ScheduleToDelete = db.Schedules.ToList().FirstOrDefault(schedule => schedule.ScheduleID == id);
                if (ScheduleToDelete != null)
                {
                    ScheduleToDelete.Status = false;
                    db.Schedules.Update(ScheduleToDelete);
                    db.SaveChanges();
                }
            }
        }
    }
}
