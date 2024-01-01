using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class NoticeDTO
    {
        public int ID { get; set; }

        public int ClassID { get; set; }

        public int TeacherID { get; set; }

        public int SectionID { get; set; }

        public string NoticeTitle { get; set; }

        public string NoticeText { get; set; }

        public DateTime NoticeDate { get; set; }
    }
}
