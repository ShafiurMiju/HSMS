using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IRepo<Admin, int, bool>, IAuth
    {
        public bool Auth(string Email, string Password)
        {
            var data = db.Admins.FirstOrDefault(admin => admin.Email.Equals(Email) && admin.Password.Equals(Password));

            if (data != null) return true;
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(Admin obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Admin obj)
        {
            throw new NotImplementedException();
        }
    }
}
