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
    internal class ADepartmentRepo : Repo, IRepo<Department, int, bool>
    {
        public List<Department> Get()
        {
            return db.Departments.ToList();
        }

        public Department Get(int id)
        {
            return db.Departments.Find(id);
        }

        public bool Post(Department obj)
        {
            db.Departments.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Department obj)
        {
            var ex = Get(obj.ID);

            db.Entry(ex).CurrentValues.SetValues(obj);

            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Departments.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
