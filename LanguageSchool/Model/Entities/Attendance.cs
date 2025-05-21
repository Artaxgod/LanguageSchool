using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSchool.Model.Entities
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public int ClientID { get; set; }
        public int ScheduleID { get; set; }
        public bool IsPresent { get; set; }

        public virtual Client Client { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
