using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SubjectTeacherDTO
    {
        public int ID { get; set; }

        public int TeacherID { get; set; }

        public int SubjectID { get; set; }

        public int ClassID { get; set; }

        public int SectionID { get; set; }
    }
}
