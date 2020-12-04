using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public int TemplateId { get; set; }
        public int ContractId { get; set; }
        public int AdminId { get; set; }
        public DateTime SubmitDate { get; set; }
        public string Provider { get; set; }
        public Boolean Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
