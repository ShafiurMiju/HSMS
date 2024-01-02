using DAL;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System.Collections.Generic;
using System.Linq;

internal class SubjectTeacherRepo : Repo, IRepo<SubjectTeacher, int, bool>
{
    public bool Delete(int id)
    {
        var ex = Get(id);
        db.SubjectTeachers.Remove(ex);
        return db.SaveChanges() > 0;
    }

    public List<SubjectTeacher> Get()
    {
        return db.SubjectTeachers.ToList();
    }

    public SubjectTeacher Get(int id)
    {
        return db.SubjectTeachers.Find(id);
    }

    public bool Post(SubjectTeacher obj)
    {
        db.SubjectTeachers.Add(obj);
        return db.SaveChanges() > 0;
    }

    public bool Update(SubjectTeacher obj)
    {
        var ex = Get(obj.ID);
        db.Entry(ex).CurrentValues.SetValues(obj);
        return db.SaveChanges() > 0;
    }
}
