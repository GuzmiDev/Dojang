using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Students 
    {
        static public void Save(StudentEntity entity)
        {
            using(var db = new DojangContext())
            {
                db.Students.Add(entity);
                db.SaveChanges();
            }
        }
        static public List<StudentEntity> GetAll()
        {
            using(var db =new DojangContext())
            {
                return db.Students.ToList();
            }
        }

       
        static public StudentEntity GetById(string id)
        {
            using (var db = new DojangContext())
            {
                return db.Students.ToList()
                    .FirstOrDefault(student => student.StudentID == id);
            }
        }
        static  public void Update(StudentEntity entity)
        {
            using(var db =new DojangContext())
            {
                db.Students.Update(entity);
                db.SaveChanges();
            }
        }
        static public void Delete(string id)
        {
            using (var db = new DojangContext())
            {
                var StudentToDelete = db.Students.ToList().FirstOrDefault(student => student.StudentID == id);
                if (StudentToDelete != null)
                {
                    StudentToDelete.Status = false;
                    db.Students.Update(StudentToDelete);
                    db.SaveChanges();
                }
            }
        }
    }
}
