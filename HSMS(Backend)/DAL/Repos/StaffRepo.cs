using DAL;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System.Collections.Generic;
using System.Linq;

internal class StaffRepo : Repo, IRepo<Staff, int, bool>
{
    public bool Delete(int id)
    {
        var ex = Get(id);
        db.Staffs.Remove(ex);
        return db.SaveChanges() > 0;
    }

    public List<Staff> Get()
    {
        return db.Staffs.ToList();
    }

    public Staff Get(int id)
    {
        return db.Staffs.Find(id);
    }

    public bool Post(Staff obj)
    {
        db.Staffs.Add(obj);
        return db.SaveChanges() > 0;
    }

    public bool Update(Staff obj)
    {
        var ex = Get(obj.ID);
        db.Entry(ex).CurrentValues.SetValues(obj);
        return db.SaveChanges() > 0;
    }
}
