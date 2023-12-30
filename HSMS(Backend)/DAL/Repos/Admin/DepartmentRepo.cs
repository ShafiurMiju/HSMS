using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DepartmentRepo : Repo, IRepo<Department, int, bool>
    {
        public List<Department> Get()
        {
            return db.Departments.ToList();
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(Department obj)
        {
            db.Departments.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Department obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
