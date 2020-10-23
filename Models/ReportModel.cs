using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class ReportModel
    {
        public int ContractId { get; set; }
        public DateTime SubmitDate { get; set; }
        public string Provider { get; set; }
        public Boolean Approved { get; set; }
        public string Admin { get; set; }
        public DateTime ApprovedDate { get; set; }
    }
}
