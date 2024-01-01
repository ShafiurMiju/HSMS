using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Token
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TokenKey { get; set; }

        [Required]
        public DateTime LoggedTime { get; set; }

        public DateTime ExpiredTime { get; set; }

        [ForeignKey("Admin")]
        public int AdminID { get; set; }

        public virtual Admin Admin { get; set; }
    }
}
