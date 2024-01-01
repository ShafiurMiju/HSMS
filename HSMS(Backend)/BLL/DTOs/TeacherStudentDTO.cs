using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TeacherStudentDTO
    {
        public int ID { get; set; }

        public int TeacherID { get; set; }

        public int StudentID { get; set; }
        public string MessageS { get; set; }
        public string MessageT { get; set; }

        public DateTime DateTime { get; set; }
    }
}
