using DAL;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

internal class ASubjectRepo : Repo, IRepo<Subject, int, bool>
{
    public bool Delete(int id)
    {
        var ex = Get(id);
        db.Subjects.Remove(ex);
        return db.SaveChanges() > 0;
    }

    public List<Subject> Get()
    {
        return db.Subjects.ToList();
    }

    public Subject Get(int id)
    {
        return db.Subjects.Find(id);
    }

    public bool Post(Subject obj)
    {
        db.Subjects.Add(obj);
        return db.SaveChanges() > 0;
    }

    public bool Update(Subject obj)
    {
        var ex = Get(obj.ID);
        db.Entry(ex).CurrentValues.SetValues(obj);
        return db.SaveChanges() > 0;
    }
}
