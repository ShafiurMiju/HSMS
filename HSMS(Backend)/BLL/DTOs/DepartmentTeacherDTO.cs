using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DepartmentTeacherDTO : DepartmentDTO
    {
        public List<TeacherDTO> Teachers { get; set; }

        public DepartmentTeacherDTO()
        {
            Teachers = new List<TeacherDTO>();
        }
    }
}
