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

        public static IRepo<SchoolInfo, int, bool> SchoolInfoData()
        {
            return new SchoolInfoRepo();
        }

        public static IRepo<Grade, int, bool> GradeData()
        {
            return new AGradeRepo();
        }

        public static IRepo<Subject, int, bool> SubjectData()
        {
            return new ASubjectRepo();
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

        public static IRepo<ExamType, int, bool> ExamTypeData()
        {
            return new AExamTypeRepo();
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

        public static IRepo<Staff, int, bool> StaffData()
        {
            return new StaffRepo();
        }

        public static IRepo<SubjectTeacher, int, bool> SubjectTeacherData()
        {
            return new SubjectTeacherRepo();
        }

        public static IStudent AStudentCountData()
        {
            return new AStudentRepo();
        }

        public static IRepo<Exam, int, bool> ExamData()
        {
            return new ExamRepo();
        }

        public static IRepo<Result, int, bool> ResultData()
        {
            return new ResultRepo();
        }

        public static IResult<Result, int> StudentResultData()
        {
            return new ResultRepo();
        }
    }
}
