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
        public virtual User User { get; set; }
        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
