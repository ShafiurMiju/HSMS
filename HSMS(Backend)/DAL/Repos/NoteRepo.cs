using DAL;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class NoteRepo : Repo, IRepo<Note, int, bool>, IDelete
{
    public bool Delete(int id)
    {
        var ex = Get(id);
        if (ex != null)
        {
            DeleteFile(ex.NoteFile);
            db.Notes.Remove(ex);
            return db.SaveChanges() > 0;
        }
        return false;
    }

    public List<Note> Get()
    {
        return db.Notes.ToList();
    }

    public Note Get(int id)
    {
        return db.Notes.Find(id);
    }

    public bool Post(Note obj)
    {
        db.Notes.Add(obj);
        return db.SaveChanges() > 0;
    }

    public bool Update(Note obj)
    {
        var ex = Get(obj.ID);
        if (ex != null)
        {
            DeleteFile(ex.NoteFile);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
        return false;
    }

    public void DeleteFile(string fileName)
    {
        if (!string.IsNullOrEmpty(fileName))
        {
            string filePath = Path.Combine("~/App_Data", fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
