using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ResultDTO
    {
        public int ID { get; set; }

        public int StudentID { get; set; }

        public int ExamID { get; set; }

        public int SubjectID { get; set; }

        public int GradeID { get; set; }

        public int MarksObtained { get; set; }

        public DateTime PublishedDate { get; set; }
    }
}
