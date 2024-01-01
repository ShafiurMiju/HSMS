using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class NoteDTO
    {
        public int ID { get; set; }

        public int TeachereID { get; set; }

        public int ClassID { get; set; }

        public int SectionID { get; set; }

        public string NoteTitle { get; set; }

        public string NoteText { get; set; }

        public string NoteFile { get; set; }

        public DateTime NoteDate { get; set; }
    }
}
