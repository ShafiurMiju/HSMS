using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ExamRoutine
    {
        public int ID { get; set; }

        [ForeignKey("Class")]
        public int ClassID { get; set; }

        [ForeignKey("Section")]
        public int SectionID { get; set; }

        [ForeignKey("Exam")]
        public int ExamID { get; set; }
        public string File { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual Class Class { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Section Section { get; set; }
    }
}
