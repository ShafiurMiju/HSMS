using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Department, int, bool> DepartmentData()
        {
            return new DepartmentRepo();
        }
        
        public static IRepo<Admin, int, bool> AdminData()
        {
            return new AdminRepo();
        }

        public static IAuth AuthData()
        {
            return new AdminRepo();
        }

        public static IRepo<Class, int, bool> ClassData()
        {
            return new ClassRepo();
        }

        public static IRepo<Section, int, bool> SectionData()
        {
            return new SectionRepo();
        }

        public static IRepo<Student, int, bool> StudentData()
        {
            return new StudentRepo();
        }
    }
}
