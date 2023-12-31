namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTableCreatedRefresh2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AcamedicNotices",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    AdminID = c.Int(nullable: false),
                    AcademicNoticeTitle = c.String(nullable: false, maxLength: 200),
                    AcademicNoticeText = c.String(nullable: false),
                    AcademicNoticeTitleDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Admins", t => t.AdminID, cascadeDelete: true)
                .Index(t => t.AdminID);

            CreateTable(
                "dbo.Messages",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    GuestID = c.Int(nullable: false),
                    AdminID = c.Int(nullable: false),
                    MessageG = c.String(),
                    MessageA = c.String(),
                    Date = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Admins", t => t.AdminID, cascadeDelete: true)
                .ForeignKey("dbo.Guests", t => t.GuestID, cascadeDelete: true)
                .Index(t => t.GuestID)
                .Index(t => t.AdminID);

            CreateTable(
                "dbo.Guests",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 20),
                    UserName = c.String(nullable: false, maxLength: 20),
                    Email = c.String(nullable: false, maxLength: 20),
                    ContactNumber = c.String(nullable: false, maxLength: 20),
                    Address = c.String(nullable: false, maxLength: 100),
                    Password = c.String(nullable: false, maxLength: 20),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.ApplyStudents",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false, maxLength: 20),
                    LastName = c.String(nullable: false, maxLength: 20),
                    FatherName = c.String(nullable: false, maxLength: 20),
                    MotherName = c.String(nullable: false, maxLength: 20),
                    Email = c.String(nullable: false, maxLength: 20),
                    ContactNumber = c.String(nullable: false, maxLength: 20),
                    DateOfBirth = c.DateTime(nullable: false),
                    Gender = c.String(nullable: false, maxLength: 20),
                    Address = c.String(nullable: false, maxLength: 200),
                    ClassID = c.Int(nullable: false),
                    SectionID = c.Int(nullable: false),
                    ProfilePic = c.String(),
                    Documents = c.String(),
                    ApplicationDate = c.DateTime(nullable: false),
                    Password = c.String(nullable: false, maxLength: 20),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.ClassID, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .Index(t => t.ClassID)
                .Index(t => t.SectionID);

            CreateTable(
                "dbo.ClassRoutines",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    ClassID = c.Int(nullable: false),
                    SectionID = c.Int(nullable: false),
                    File = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                    ExpiredDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.ClassID, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .Index(t => t.ClassID)
                .Index(t => t.SectionID);

            CreateTable(
                "dbo.ExamRoutines",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    ClassID = c.Int(nullable: false),
                    SectionID = c.Int(nullable: false),
                    ExamID = c.Int(nullable: false),
                    File = c.String(),
                    Date = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.ClassID, cascadeDelete: true)
                .ForeignKey("dbo.Exams", t => t.ExamID, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .Index(t => t.ClassID)
                .Index(t => t.SectionID)
                .Index(t => t.ExamID);

            CreateTable(
                "dbo.Exams",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                    ExamTypeID = c.Int(nullable: false),
                    ClassID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.ClassID)
                .ForeignKey("dbo.ExamTypes", t => t.ExamTypeID, cascadeDelete: true)
                .Index(t => t.ExamTypeID)
                .Index(t => t.ClassID);

            CreateTable(
                "dbo.ExamTypes",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    ExamTypeName = c.String(nullable: false, maxLength: 20),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Results",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    StudentID = c.Int(nullable: false),
                    ExamID = c.Int(nullable: false),
                    SubjectID = c.Int(nullable: false),
                    GradeID = c.Int(nullable: false),
                    MarksObtained = c.Int(nullable: false),
                    PublishedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Exams", t => t.ExamID, cascadeDelete: true)
                .ForeignKey("dbo.Grades", t => t.GradeID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.ExamID)
                .Index(t => t.SubjectID)
                .Index(t => t.GradeID);

            CreateTable(
                "dbo.Grades",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    GradeName = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.TeacherStudentChats",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    TeacherID = c.Int(nullable: false),
                    StudentID = c.Int(nullable: false),
                    MessageS = c.String(),
                    MessageT = c.String(),
                    DateTime = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: true)
                .Index(t => t.TeacherID)
                .Index(t => t.StudentID);

            CreateTable(
                "dbo.Teachers",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false, maxLength: 20),
                    LastName = c.String(nullable: false, maxLength: 20),
                    Email = c.String(nullable: false, maxLength: 20),
                    ContactNumber = c.String(nullable: false, maxLength: 20),
                    DateOfBirth = c.DateTime(nullable: false),
                    Gender = c.String(nullable: false, maxLength: 20),
                    Education = c.String(nullable: false, maxLength: 200),
                    Password = c.String(nullable: false, maxLength: 20),
                    ProfilePicture = c.String(),
                    DepartmentID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);

            CreateTable(
                "dbo.Notes",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    TeachereID = c.Int(nullable: false),
                    ClassID = c.Int(nullable: false),
                    SectionID = c.Int(nullable: false),
                    NoteTitle = c.String(nullable: false, maxLength: 100),
                    NoteText = c.String(nullable: false),
                    NoteFile = c.String(),
                    NoteDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.ClassID, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeachereID, cascadeDelete: true)
                .Index(t => t.TeachereID)
                .Index(t => t.ClassID)
                .Index(t => t.SectionID);

            CreateTable(
                "dbo.Notices",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    ClassID = c.Int(nullable: false),
                    TeacherID = c.Int(nullable: false),
                    SectionID = c.Int(nullable: false),
                    NoticeTitle = c.String(nullable: false, maxLength: 100),
                    NoticeText = c.String(nullable: false),
                    NoticeDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.ClassID, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: true)
                .Index(t => t.ClassID)
                .Index(t => t.TeacherID)
                .Index(t => t.SectionID);

            CreateTable(
                "dbo.SubjectTeachers",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    TeacherID = c.Int(nullable: false),
                    SubjectID = c.Int(nullable: false),
                    ClassID = c.Int(nullable: false),
                    SectionID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.ClassID, cascadeDelete: true)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: true)
                .Index(t => t.TeacherID)
                .Index(t => t.SubjectID)
                .Index(t => t.ClassID)
                .Index(t => t.SectionID);

            CreateTable(
                "dbo.Subjects",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    SubjectName = c.String(nullable: false, maxLength: 20),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.SchoolInfoes",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    SchoolName = c.String(nullable: false, maxLength: 100),
                    Address = c.String(nullable: false, maxLength: 200),
                    ContactNumber = c.String(nullable: false, maxLength: 20),
                    PrincipalName = c.String(maxLength: 20),
                    Logo = c.String(),
                    Info = c.String(nullable: false),
                    Email = c.String(),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Staffs",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false, maxLength: 20),
                    LastName = c.String(nullable: false, maxLength: 20),
                    Email = c.String(nullable: false, maxLength: 20),
                    ContactNumber = c.String(nullable: false, maxLength: 20),
                    DateOfBirth = c.DateTime(nullable: false),
                    Gender = c.String(nullable: false, maxLength: 20),
                    Address = c.String(nullable: false, maxLength: 100),
                })
                .PrimaryKey(t => t.ID);

        }

        public override void Down()
        {
            DropForeignKey("dbo.ApplyStudents", "SectionID", "dbo.Sections");
            DropForeignKey("dbo.ApplyStudents", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.ClassRoutines", "SectionID", "dbo.Sections");
            DropForeignKey("dbo.ExamRoutines", "SectionID", "dbo.Sections");
            DropForeignKey("dbo.ExamRoutines", "ExamID", "dbo.Exams");
            DropForeignKey("dbo.Results", "SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.Results", "StudentID", "dbo.Students");
            DropForeignKey("dbo.TeacherStudentChats", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.SubjectTeachers", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.SubjectTeachers", "SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.SubjectTeachers", "SectionID", "dbo.Sections");
            DropForeignKey("dbo.SubjectTeachers", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.Notices", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Notices", "SectionID", "dbo.Sections");
            DropForeignKey("dbo.Notices", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.Notes", "TeachereID", "dbo.Teachers");
            DropForeignKey("dbo.Notes", "SectionID", "dbo.Sections");
            DropForeignKey("dbo.Notes", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.Teachers", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.TeacherStudentChats", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Results", "GradeID", "dbo.Grades");
            DropForeignKey("dbo.Results", "ExamID", "dbo.Exams");
            DropForeignKey("dbo.Exams", "ExamTypeID", "dbo.ExamTypes");
            DropForeignKey("dbo.Exams", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.ExamRoutines", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.ClassRoutines", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.AcamedicNotices", "AdminID", "dbo.Admins");
            DropForeignKey("dbo.Messages", "GuestID", "dbo.Guests");
            DropForeignKey("dbo.Messages", "AdminID", "dbo.Admins");
            DropIndex("dbo.SubjectTeachers", new[] { "SectionID" });
            DropIndex("dbo.SubjectTeachers", new[] { "ClassID" });
            DropIndex("dbo.SubjectTeachers", new[] { "SubjectID" });
            DropIndex("dbo.SubjectTeachers", new[] { "TeacherID" });
            DropIndex("dbo.Notices", new[] { "SectionID" });
            DropIndex("dbo.Notices", new[] { "TeacherID" });
            DropIndex("dbo.Notices", new[] { "ClassID" });
            DropIndex("dbo.Notes", new[] { "SectionID" });
            DropIndex("dbo.Notes", new[] { "ClassID" });
            DropIndex("dbo.Notes", new[] { "TeachereID" });
            DropIndex("dbo.Teachers", new[] { "DepartmentID" });
            DropIndex("dbo.TeacherStudentChats", new[] { "StudentID" });
            DropIndex("dbo.TeacherStudentChats", new[] { "TeacherID" });
            DropIndex("dbo.Results", new[] { "GradeID" });
            DropIndex("dbo.Results", new[] { "SubjectID" });
            DropIndex("dbo.Results", new[] { "ExamID" });
            DropIndex("dbo.Results", new[] { "StudentID" });
            DropIndex("dbo.Exams", new[] { "ClassID" });
            DropIndex("dbo.Exams", new[] { "ExamTypeID" });
            DropIndex("dbo.ExamRoutines", new[] { "ExamID" });
            DropIndex("dbo.ExamRoutines", new[] { "SectionID" });
            DropIndex("dbo.ExamRoutines", new[] { "ClassID" });
            DropIndex("dbo.ClassRoutines", new[] { "SectionID" });
            DropIndex("dbo.ClassRoutines", new[] { "ClassID" });
            DropIndex("dbo.ApplyStudents", new[] { "SectionID" });
            DropIndex("dbo.ApplyStudents", new[] { "ClassID" });
            DropIndex("dbo.Messages", new[] { "AdminID" });
            DropIndex("dbo.Messages", new[] { "GuestID" });
            DropIndex("dbo.AcamedicNotices", new[] { "AdminID" });
            DropTable("dbo.Staffs");
            DropTable("dbo.SchoolInfoes");
            DropTable("dbo.Subjects");
            DropTable("dbo.SubjectTeachers");
            DropTable("dbo.Notices");
            DropTable("dbo.Notes");
            DropTable("dbo.Teachers");
            DropTable("dbo.TeacherStudentChats");
            DropTable("dbo.Grades");
            DropTable("dbo.Results");
            DropTable("dbo.ExamTypes");
            DropTable("dbo.Exams");
            DropTable("dbo.ExamRoutines");
            DropTable("dbo.ClassRoutines");
            DropTable("dbo.ApplyStudents");
            DropTable("dbo.Guests");
            DropTable("dbo.Messages");
            DropTable("dbo.AcamedicNotices");
        }
    }
}
