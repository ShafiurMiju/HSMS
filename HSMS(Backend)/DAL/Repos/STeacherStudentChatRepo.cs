using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.ReposAdmin
{
    internal class TeacherStudentChatRepo : Repo, IRepo<TeacherStudentChat, int, bool>
    {
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.TeacherStudentChats.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<TeacherStudentChat> Get()
        {
            return db.TeacherStudentChats.ToList();
        }

        public TeacherStudentChat Get(int id)
        {
            return db.TeacherStudentChats.Find(id);
        }

        public bool Post(TeacherStudentChat obj)
        {
            db.TeacherStudentChats.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(TeacherStudentChat obj)
        {
            var ex = Get(obj.ID);

            db.Entry(ex).CurrentValues.SetValues(obj);

            return db.SaveChanges() > 0;
        }
    }
}