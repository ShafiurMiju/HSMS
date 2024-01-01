using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IAdmin, IAuth<bool>
    {
        public bool Auth(string Email, string Password)
        {
            var data = db.Admins.FirstOrDefault(admin => admin.Email.Equals(Email) && admin.Password.Equals(Password));

            if (data != null) return true;
            return false;
        }

        EF.Models.Admin IAdmin.Get(int id)
        {
            return db.Admins.Find(id);
        }

        EF.Models.Admin IAdmin.Get(string email)
        {
            return db.Admins.FirstOrDefault(admin => admin.Email.Equals(email));
        }
    }
}
