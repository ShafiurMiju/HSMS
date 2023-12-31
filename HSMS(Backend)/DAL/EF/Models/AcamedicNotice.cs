using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class AcamedicNotice
    {
        public int ID { get; set; }

        [ForeignKey("Admin")]
        public int AdminID { get; set; }

        [Required]
        [StringLength(200)]
        public string AcademicNoticeTitle { get; set; }

        [Required]
        public string AcademicNoticeText { get; set; }

        [Required]
        public DateTime AcademicNoticeTitleDate { get; set; }

        public virtual Admin Admin { get; set; }
    }
}
