using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Admin
{
    internal class TeacherRepo : Repo, IRepo<Teacher, int, bool>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Teacher> Get()
        {
            throw new NotImplementedException();
        }

        public Teacher Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(Teacher obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Teacher obj)
        {
            throw new NotImplementedException();
        }
    }
}
