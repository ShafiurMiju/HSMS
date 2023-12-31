using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ApplyStudent
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string FatherName { get; set; }

        [Required]
        [StringLength(20)]
        public string MotherName { get; set; }

        [Required]
        [StringLength(20)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string ContactNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(20)]
        public string Gender { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [ForeignKey("Class")]
        public int ClassID { get; set; }

        [ForeignKey("Section")]
        public int SectionID { get; set; }

        public string ProfilePic { get; set; }
        public string Documents { get; set; }

        [Required]
        public DateTime ApplicationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        public virtual Class Class { get; set; }
        public virtual Section Section { get; set; }
    }
}
