using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSchool.Model.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        public int ClientID { get; set; }
        public int TeacherID { get; set; }
        public string MessageText { get; set; }
        public DateTime SentDate { get; set; }
        public bool IsRead { get; set; }

        // Navigation properties
        public virtual Client Client { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
