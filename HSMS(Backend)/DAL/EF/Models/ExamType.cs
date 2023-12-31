using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ExamType
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string ExamTypeName { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public ExamType()
        {
            Exams = new List<Exam>();
        }
    }
}
