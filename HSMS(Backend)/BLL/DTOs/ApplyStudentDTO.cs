using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ApplyStudentDTO
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string Email { get; set; }

        public string ContactNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public int ClassID { get; set; }

        public int SectionID { get; set; }

        public string ProfilePic { get; set; }
        public string Documents { get; set; }

        public DateTime ApplicationDate { get; set; }

        public string Password { get; set; }
    }
}
