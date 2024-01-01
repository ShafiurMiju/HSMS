using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ClassRoutineDTO
    {
        public int ID { get; set; }

        public int ClassID { get; set; }

        public int SectionID { get; set; }

        public string File { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ExpiredDate { get; set; }
    }
}
