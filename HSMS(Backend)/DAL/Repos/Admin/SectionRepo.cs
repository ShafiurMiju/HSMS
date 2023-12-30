using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SectionRepo : Repo, IRepo<Section, int, bool>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Section> Get()
        {
            return db.Sections.ToList();    
        }

        public Section Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(Section obj)
        {
            db.Sections.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Section obj)
        {
            throw new NotImplementedException();
        }
    }
}
