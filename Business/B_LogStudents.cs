using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_LogStudents
    {
        static public void Save(LogStudentsEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.logStudents.Add(entity);
                db.SaveChanges();
            }
        }
        static public List<LogStudentsEntity> GetAll()
        {
            using (var db = new DojangContext())
            {
                return db.logStudents.ToList();
            }
        }
        static public LogStudentsEntity GetById(int id)
        {
            using (var db = new DojangContext())
            {
                return db.logStudents.ToList().FirstOrDefault(logStudents => logStudents.Id == id);
            }
        }
        static public void Update(LogStudentsEntity entity)
        {
            using (var db = new DojangContext())
            {
                db.logStudents.Update(entity);
                db.SaveChanges();
            }
        }
        static public void Delete(int id)
        {
            using (var db = new DojangContext())
            {
                var LogToDelete = db.logStudents.ToList().FirstOrDefault(logStudents => logStudents.Id == id);
                if (LogToDelete != null)
                {
                    LogToDelete.Status = false;
                    db.logStudents.Update(LogToDelete);
                }
            }
        }

    }
}
