using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class ReportToContract
    {
        public int ReportToContractId { get; set; }
        public int ReportId { get; set; }
        public int ContractId { get; set; }
        public virtual Report Report { get; set; }
        public virtual Contract Contract { get; set; }

    }
}
