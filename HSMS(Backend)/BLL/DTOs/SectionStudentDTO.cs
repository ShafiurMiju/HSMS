using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SectionStudentDTO : SectionDTO
    {
        public List<StudentDTO> Students { get; set; }

        public SectionStudentDTO()
        {
            Students= new List<StudentDTO>();
        }
    }
}
