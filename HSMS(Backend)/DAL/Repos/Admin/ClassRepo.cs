using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ClassRepo : Repo, IRepo<Class, int, bool>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Class> Get()
        {
            return db.Classes.ToList();
        }

        public Class Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(Class obj)
        {
            db.Classes.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Class obj)
        {
            throw new NotImplementedException();
        }
    }
}
