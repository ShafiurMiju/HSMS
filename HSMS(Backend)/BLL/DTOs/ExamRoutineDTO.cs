using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ExamRoutineDTO
    {
        public int ID { get; set; }

        public int ClassID { get; set; }

        public int SectionID { get; set; }

        public int ExamID { get; set; }
        public string File { get; set; }

        public DateTime Date { get; set; }
    }
}
