using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SchoolInfoDTO
    {
        public int ID { get; set; }

        public string SchoolName { get; set; }

        public string Address { get; set; }

        public string ContactNumber { get; set; }

        public string PrincipalName { get; set; }

        public string Logo { get; set; }

        public string Info { get; set; }
        public string Email { get; set; }
    }
}
