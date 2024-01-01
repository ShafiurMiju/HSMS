using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repos
{
    internal class StudentRepo : Repo, IRepo<Student, int, bool>
    {
        public bool Delete(int id)
        {
            var ex = DataAccessFactory.StudentData().Get(id);

            db.Students.Remove(ex);

            if (db.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }

        public List<Student> Get()
        {
            return db.Students.ToList();
        }

        public Student Get(int id)
        {
            return db.Students.Find(id);
        }

        public bool Post(Student obj)
        {
            db.Students.Add(obj);
            if(db.SaveChanges() > 0)return true;
            return false;
        }

        public bool Update(Student obj)
        {
            var ex = DataAccessFactory.StudentData().Get(obj.ID);

            db.Entry(ex).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0){
                return true;
            }
            return false;
        }
    }
}
