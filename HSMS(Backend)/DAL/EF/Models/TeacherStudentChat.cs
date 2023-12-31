using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class TeacherStudentChat
    {
        public int ID { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public string MessageS { get; set; }
        public string MessageT { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
