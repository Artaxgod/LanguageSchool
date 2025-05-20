using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSchool.Model.Entities
{
    public class Group
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int LanguageID { get; set; }

        // Navigation properties
        public Language Language { get; set; }
        public ICollection<GroupClient> GroupClients { get; set; }
        public ICollection<GroupSchedule> GroupSchedules { get; set; }
        public ICollection<GroupTeacher> GroupTeachers { get; set; }
    }
}
