using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Subject
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string SubjectName { get; set; }

        public virtual ICollection<Result> Results { get; set; }
        public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }

        public Subject()
        {
            Results = new List<Result>();
            SubjectTeachers = new List<SubjectTeacher>();
        }
    }
}
