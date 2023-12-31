using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Section
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SectionName { get; set; }

        public virtual ICollection<ApplyStudent> ApplyStudents { get; set; }
        public virtual ICollection<ExamRoutine> ExamRoutines { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Notice> Notices { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
        public virtual ICollection<ClassRoutine> ClassRoutines { get; set; }

        public Section()
        {
            ApplyStudents = new List<ApplyStudent>();
            ExamRoutines = new List<ExamRoutine>();
            Notes = new List<Note>();
            Notices = new List<Notice>();
            Students = new List<Student>();
            SubjectTeachers = new List<SubjectTeacher>();
            ClassRoutines = new List<ClassRoutine>();
        }
    }
}
