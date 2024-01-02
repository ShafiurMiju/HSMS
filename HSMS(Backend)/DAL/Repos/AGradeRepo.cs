using DAL;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System.Collections.Generic;
using System.Linq;

internal class AGradeRepo : Repo, IRepo<Grade, int, bool>
{
    public bool Delete(int id)
    {
        var ex = Get(id);
        db.Grades.Remove(ex);
        return db.SaveChanges() > 0;
    }

    public List<Grade> Get()
    {
        return db.Grades.ToList();
    }

    public Grade Get(int id)
    {
        return db.Grades.Find(id);
    }

    public bool Post(Grade obj)
    {
        db.Grades.Add(obj);
        return db.SaveChanges() > 0;
    }

    public bool Update(Grade obj)
    {
        var ex = Get(obj.ID);
        db.Entry(ex).CurrentValues.SetValues(obj);
        return db.SaveChanges() > 0;
    }
}
