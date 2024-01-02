using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.ReposAdmin
{
    internal class SNoteRepo : Repo, IRepo<Note, int, bool>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Note> Get()
        {
            return db.Notes.ToList();
        }

        public Note Get(int id)
        {
            return db.Notes.Find(id);
        }

        public bool Post(Note obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Note obj)
        {
            throw new NotImplementedException();
        }
    }
}