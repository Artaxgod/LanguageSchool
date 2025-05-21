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
        public virtual Language Language { get; set; }
        public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
        public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public virtual ICollection<Homework> Homeworks { get; set; } = new List<Homework>();
    }
}
