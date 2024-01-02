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
            var ex = Get(id);
            db.Teachers.Remove(ex);
            return db.SaveChanges() > 0;
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
            return db.SaveChanges() > 0;
        }

        public bool Update(Teacher obj)
        {
            var ex = Get(obj.ID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

        public bool Search(string data)
        {
            var exdata = db.Teachers.FirstOrDefault(teacher => teacher.Email.Equals(data));

            if (exdata != null) return true;
            return false;

        }
    }
}
