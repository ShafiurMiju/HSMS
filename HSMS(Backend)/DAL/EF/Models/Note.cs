using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Note
    {
        public int ID { get; set; }

        [ForeignKey("Teacher")]
        public int TeachereID { get; set; }

        [ForeignKey("Class")]
        public int ClassID { get; set; }

        [ForeignKey("Section")]
        public int SectionID { get; set; }

        [Required]
        [StringLength(100)]
        public string NoteTitle { get; set; }

        [Required]
        public string NoteText { get; set; }

        public string NoteFile { get; set; }
        public DateTime NoteDate { get; set; }

        public virtual Class Class { get; set; }
        public virtual Section Section { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
