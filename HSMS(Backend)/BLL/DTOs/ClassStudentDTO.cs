using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ClassStudentDTO : ClassDTO
    {
        public List<StudentDTO> Students { get; set; }

        public ClassStudentDTO()
        {
            Students = new List<StudentDTO>();
        }
    }
}
