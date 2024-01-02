using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class HSMSContext : DbContext
    {
        public DbSet<AcamedicNotice> AcamedicNotices { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ApplyStudent> ApplyStudents { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassRoutine> ClassRoutines { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamRoutine> ExamRoutines { get; set; }
        public DbSet<ExamType> ExamTypes { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<SchoolInfo> SchoolInfoes { get; set; }       
        public DbSet<Section> Sections { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Student> Students { get; set; }        
        public DbSet<Subject> Subjects { get; set; }        
        public DbSet<SubjectTeacher> SubjectTeachers { get; set; }        
        public DbSet<Teacher> Teachers { get; set; }        
        public DbSet<TeacherStudentChat> TeacherStudentChats { get; set; }        
        public DbSet<Token> Tokens { get; set; }        
        
    }
}
