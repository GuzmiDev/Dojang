using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class B_Schedule
    {
        public void Save(ScheduleEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.Schedules.Add(entity);
                db.SaveChanges();
            }
        }
        public List<ScheduleEntity> GetAll()
        {
            using (var db = new DojangContext())
            {
                return db.Schedules.ToList();
            }
        }
        public ScheduleEntity GetById(int id)
        {
            using (var db = new DojangContext())
            {
                return db.Schedules.ToList().FirstOrDefault(schedule => schedule.ScheduleID == id);
            }
        }
        public void Update(ScheduleEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.Schedules.Update(entity);
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var db = new DojangContext())
            {
                var StudentToDelete = db.Schedules.ToList().FirstOrDefault(schedule => schedule.ScheduleID == id);
                if (StudentToDelete != null)
                {
                    StudentToDelete.Status = false;
                    db.Schedules.Update(StudentToDelete);
                }
            }
        }
    }
}
