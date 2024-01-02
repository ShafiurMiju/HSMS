using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class ExamRepo : Repo, IRepo<Exam, int, bool>
    {
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Exams.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Exam> Get()
        {
            return db.Exams.ToList();
        }

        public Exam Get(int id)
        {
            return db.Exams.Find(id);
        }

        public bool Post(Exam obj)
        {
            db.Exams.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Exam obj)
        {
            var ex = Get(obj.ID);

            db.Entry(ex).CurrentValues.SetValues(obj);

            return db.SaveChanges() > 0;
        }
    }
}
