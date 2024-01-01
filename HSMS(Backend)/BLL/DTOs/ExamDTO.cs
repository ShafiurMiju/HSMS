using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ExamDTO
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public int ExamTypeID { get; set; }

        public int ClassID { get; set; }
    }
}
