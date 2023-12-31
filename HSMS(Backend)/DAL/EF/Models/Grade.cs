using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Grade
    {
        public Grade()
        {
            Results = new List<Result>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string GradeName { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}
