using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSchool.Model.Entities
{
    public class Contract
    {
        public int ContractID { get; set; }
        public int ClientID { get; set; }
        public int ServiceID { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime? EndDate { get; set; }

        // Navigation properties
        public Client Client { get; set; }
        public Service Service { get; set; }
    }
}
