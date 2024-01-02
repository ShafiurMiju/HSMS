using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Admin
{

    internal class ATeacherRepo : Repo, IRepo<Teacher, int, bool>, ISearch<bool, string>
    {
        public bool Delete(int id)
        {
            var ex = DataAccessFactory.ATeacherData().Get(id);

            db.Teachers.Remove(ex);

            if (db.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }

        public List<Teacher> Get()
        {
            return db.Teachers.ToList();
        }

        public Teacher Get(int id)
        {
            return db.Teachers.Find(id);
        }

        public bool Post(Teacher obj)
        {
            db.Teachers.Add(obj);
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public bool Search(string data)
        {
            var exdata = db.Teachers.FirstOrDefault(teacher => teacher.Email.Equals(data));

            if (exdata != null) return true;
            return false;

        }

        public bool Update(Teacher obj)
        {
            var ex = DataAccessFactory.ATeacherData().Get(obj.ID);

            db.Entry(ex).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

    }
}
