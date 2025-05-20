using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSchool.Model.Entities
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public int UserID { get; set; }
        public string Specialization { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<GroupTeacher> GroupTeachers { get; set; }
    }
}
