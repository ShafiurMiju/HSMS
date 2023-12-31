using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Exam
    {
        public int ID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("ExamType")]
        public int ExamTypeID { get; set; }

        [ForeignKey("Class")]
        public int ClassID { get; set; }

        public virtual Class Class { get; set; }
        public virtual ExamType ExamType { get; set; }

        public virtual ICollection<ExamRoutine> ExamRoutines { get; set; }
        public virtual ICollection<Result> Results { get; set; }

        public Exam()
        {
            ExamRoutines = new List<ExamRoutine>();
            Results = new List<Result>();
        }
    }
}
