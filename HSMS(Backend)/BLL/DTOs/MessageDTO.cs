using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MessageDTO
    {
        public int ID { get; set; }

        public int GuestID { get; set; }

        public int AdminID { get; set; }
        public string MessageG { get; set; }
        public string MessageA { get; set; }

        public DateTime Date { get; set; }
    }
}
