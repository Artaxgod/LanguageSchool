using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSchool.Model.Entities
{
    public class Client
    {
        public int ClientID { get; set; }
        public int UserID { get; set; }
        public string AdditionalInfo { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<GroupClient> GroupClients { get; set; }
    }
}
