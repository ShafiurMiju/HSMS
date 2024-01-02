using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Teacher
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string ContactNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(20)]
        public string Gender { get; set; }

        [Required]
        [StringLength(200)]
        public string Education { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }
        public string ProfilePicture { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Notice> Notices { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
        public virtual ICollection<TeacherStudentChat> TeacherStudentChats { get; set; }

        public Teacher()
        {
            Notes = new List<Note>();
            Notices = new List<Notice>();
            SubjectTeachers = new List<SubjectTeacher>();
            TeacherStudentChats = new List<TeacherStudentChat>();
        }
    }
}
