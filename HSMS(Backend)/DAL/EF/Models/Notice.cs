using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Notice
    {
        public int ID { get; set; }

        [ForeignKey("Class")]
        public int ClassID { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }

        [ForeignKey("Section")]
        public int SectionID { get; set; }

        [Required]
        [StringLength(100)]
        public string NoticeTitle { get; set; }

        [Required]
        public string NoticeText { get; set; }

        [Required]
        public DateTime NoticeDate { get; set; }

        public virtual Class Class { get; set; }
        public virtual Section Section { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
