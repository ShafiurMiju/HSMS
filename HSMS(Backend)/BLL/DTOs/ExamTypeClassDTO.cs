using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ExamTypeClassDTO: ExamDTO
    {
        public ExamTypeDTO ExamType { get; set; }
        public ClassDTO Class { get; set; }


    }
}
