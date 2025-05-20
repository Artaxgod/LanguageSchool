using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSchool.Model.Entities
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public int TeacherID { get; set; }
        public DateTime LessonDate { get; set; }
        public TimeSpan LessonTime { get; set; }
        public string Topic { get; set; }

        // Navigation properties
        public Teacher Teacher { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<GroupSchedule> GroupSchedules { get; set; }
        public ICollection<Homework> Homeworks { get; set; }
    }
}
