using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Class
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string ClassName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public Class()
        {
            Students= new List<Student>();
        }
    }
}
