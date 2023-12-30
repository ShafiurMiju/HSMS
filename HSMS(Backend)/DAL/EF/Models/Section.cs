using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Section
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SectionName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public Section()
        {
            Students = new List<Student>();
        }
    }
}
