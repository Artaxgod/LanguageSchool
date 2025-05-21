using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSchool.Model.Entities
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public DateTime FeedbackDate { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; }
        public bool IsRead { get; set; }

        // Navigation properties
        public virtual User User { get; set; }
    }
}
