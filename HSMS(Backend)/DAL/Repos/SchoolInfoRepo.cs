using DAL;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System.Collections.Generic;
using System.Linq;

internal class SchoolInfoRepo : Repo, IRepo<SchoolInfo, int, bool>
{
    public bool Delete(int id)
    {
        var ex = Get(id);
        db.SchoolInfoes.Remove(ex);
        return db.SaveChanges() > 0;
    }

    public List<SchoolInfo> Get()
    {
        return db.SchoolInfoes.ToList();
    }

    public SchoolInfo Get(int id)
    {
        return db.SchoolInfoes.Find(id);
    }

    public bool Post(SchoolInfo obj)
    {
        db.SchoolInfoes.Add(obj);
        return db.SaveChanges() > 0;
    }

    public bool Update(SchoolInfo obj)
    {
        var ex = Get(obj.ID);
        db.Entry(ex).CurrentValues.SetValues(obj);
        return db.SaveChanges() > 0;
    }
}
