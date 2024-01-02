using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repos
{
    internal class AStudentRepo : Repo, IRepo<Student, int, bool>, ISearch<bool, string>, IStudent
    {
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Students.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Student> Get()
        {
            return db.Students.ToList();
        }

        public Student Get(int id)
        {
            return db.Students.Find(id);
        }

        public bool Post(Student obj)
        {
            db.Students.Add(obj);
            if(db.SaveChanges() > 0)return true;
            return false;
        }

        public bool Search(string data)
        {
            var exdata = db.Students.FirstOrDefault(student => student.Email.Equals(data));

            if (exdata != null) return true;
            return false;

        }

        public bool Update(Student obj)
        {
            var ex = Get(obj.ID);
            if(ex == null) return false;

            db.Entry(ex).CurrentValues.SetValues(obj);

            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public List<Student> GetByClassAndSection(int classId, int sectionId)
        {
            return db.Students.Where(s => s.ClassID == classId && s.SectionID == sectionId).ToList();
        }

 

       
    }
}
