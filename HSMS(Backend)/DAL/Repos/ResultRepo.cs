using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class ResultRepo : Repo, IRepo<Result, int, bool>, IResult<Result, int>
    {
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Results.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Result> Get()
        {
            return db.Results.ToList();
        }

        public Result Get(int id)
        {
            return db.Results.Find(id);
        }

        public List<Result> GetResultsByStudent(int id)
        {
            return db.Results.Where(r => r.StudentID == id).ToList();
        }

        public bool Post(Result obj)
        {
            db.Results.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Result obj)
        {
            var ex = Get(obj.ID);

            db.Entry(ex).CurrentValues.SetValues(obj);

            return db.SaveChanges() > 0;
        }


    }
}
