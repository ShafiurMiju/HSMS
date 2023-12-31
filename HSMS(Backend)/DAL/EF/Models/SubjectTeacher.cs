using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class SubjectTeacher
    {
        public int ID { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }

        [ForeignKey("Subject")]
        public int SubjectID { get; set; }

        [ForeignKey("Class")]
        public int ClassID { get; set; }

        [ForeignKey("Section")]
        public int SectionID { get; set; }

        public virtual Class Class { get; set; }
        public virtual Section Section { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
