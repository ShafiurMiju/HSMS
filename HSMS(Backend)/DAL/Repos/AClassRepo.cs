using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AClassRepo : Repo, IRepo<Class, int, bool>
    {
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Classes.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Class> Get()
        {
            return db.Classes.ToList();
        }

        public Class Get(int id)
        {
            return db.Classes.Find(id);
        }

        public bool Post(Class obj)
        {
            db.Classes.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Class obj)
        {
            var ex = Get(obj.ID);

            db.Entry(ex).CurrentValues.SetValues(obj);

            return db.SaveChanges() > 0;
        }
    }
}
