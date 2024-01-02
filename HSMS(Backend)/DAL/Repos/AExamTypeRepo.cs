using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System.Collections.Generic;
using System.Linq;

internal class AExamTypeRepo : Repo, IRepo<ExamType, int, bool>
{
    public bool Delete(int id)
    {
        var ex = Get(id);
        db.ExamTypes.Remove(ex);
        return db.SaveChanges() > 0;
    }

    public List<ExamType> Get()
    {
        return db.ExamTypes.ToList();
    }

    public ExamType Get(int id)
    {
        return db.ExamTypes.Find(id);
    }

    public bool Post(ExamType obj)
    {
        db.ExamTypes.Add(obj);
        return db.SaveChanges() > 0;
    }

    public bool Update(ExamType obj)
    {
        var ex = Get(obj.ID);
        db.Entry(ex).CurrentValues.SetValues(obj);
        return db.SaveChanges() > 0;
    }
}
