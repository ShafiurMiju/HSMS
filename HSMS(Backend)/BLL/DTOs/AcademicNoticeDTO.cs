using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AcademicNoticeDTO
    {
        public int ID { get; set; }
        public int AdminID { get; set; }

        public string AcademicNoticeTitle { get; set; }

        public string AcademicNoticeText { get; set; }

        public DateTime AcademicNoticeTitleDate { get; set; }
    }
}
