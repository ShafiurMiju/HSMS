using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class SchoolInfo
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string SchoolName { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        [StringLength(20)]
        public string ContactNumber { get; set; }

        [StringLength(20)]
        public string PrincipalName { get; set; }

        public string Logo { get; set; }

        [Required]
        public string Info { get; set; }
        public string Email { get; set; }
    }
}
