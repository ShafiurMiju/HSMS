using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ClassRoutine
    {
        public int ID { get; set; }

        [ForeignKey("Class")]
        public int ClassID { get; set; }

        [ForeignKey("Section")]
        public int SectionID { get; set; }

        public string File { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime ExpiredDate { get; set; }

        public virtual Class Class { get; set; }
        public virtual Section Section { get; set; }
    }
}
