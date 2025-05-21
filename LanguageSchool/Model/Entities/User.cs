using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSchool.Model.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public byte[] Photo { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }

        // Navigation properties
        public virtual Role Role { get; set; }
        public virtual Client Client { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
