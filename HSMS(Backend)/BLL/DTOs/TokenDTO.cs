using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TokenDTO
    {
        public int ID { get; set; }

        public string TokenKey { get; set; }

        public DateTime LoggedTime { get; set; }

        public DateTime ExpiredTime { get; set; }

        public int AdminID { get; set; }
    }
}
