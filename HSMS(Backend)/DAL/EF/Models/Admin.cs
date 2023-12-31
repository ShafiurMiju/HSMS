using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(20)]
        public string ContactNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string Gender { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        public virtual ICollection<AcamedicNotice> AcamedicNotices { get; set;}
        public virtual ICollection<Message> Messages { get; set; }
        public Admin() 
        {
            AcamedicNotices = new List<AcamedicNotice>();
            Messages = new List<Message>();
        }
    }
}
