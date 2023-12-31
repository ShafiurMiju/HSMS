using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Message
    {
        public int ID { get; set; }

        [ForeignKey("Guest")]
        public int GuestID { get; set; }

        [ForeignKey("Admin")]
        public int AdminID { get; set; }
        public string MessageG { get; set; }
        public string MessageA{ get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
