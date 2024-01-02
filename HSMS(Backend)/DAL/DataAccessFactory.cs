using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using DAL.Repos.Admin;
using DAL.Repos.ReposAdmin;
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
            return new ADepartmentRepo();
        }
        
        public static IAdmin AdminData()
        {
            return new AdminRepo();
        }

        public static IAuth <bool> AuthData()
        {
            return new AdminRepo();
        }

        public static IRepo<Class, int, bool> ClassData()
        {
            return new AClassRepo();
        }

        public static IRepo<Section, int, bool> SectionData()
        {
            return new ASectionRepo();
        }

        public static IRepo<Student, int, bool> AStudentData()
        {
            return new AStudentRepo();
        }

        public static IRepo<Teacher, int, bool> ATeacherData()
        {
            return new ATeacherRepo();
        }

        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }

        public static ISearch<bool, string>SearchData()
        {
            return new AStudentRepo();
        }
        
        public static ISearch<bool, string>TSearchData()
        {
            return new ATeacherRepo();
        }

        public static IRepo<TeacherStudentChat, int, bool> TeacherStudentChatsData()
        {
            return new TeacherStudentChatRepo();
        }

        public static IRepo<Note, int, bool> NoteData()
        {
            return new SNoteRepo();
        }
    }
}
