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
    internal class ASectionRepo : Repo, IRepo<Section, int, bool>
    {
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Sections.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Section> Get()
        {
            return db.Sections.ToList();    
        }

        public Section Get(int id)
        {
            return db.Sections.Find(id);
        }

        public bool Post(Section obj)
        {
            db.Sections.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Section obj)
        {
            var ex = Get(obj.ID);

            db.Entry(ex).CurrentValues.SetValues(obj);

            return db.SaveChanges() > 0;
        }
    }
}
