using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.ViewModels
{
    public class ReportViewModel
    {
        public int ReportId { get; set; }
        public DateTime SubmitDate { get; set; }
        public bool Approved { get; set; }
        public DateTime ApprovedDate { get; set; }
        public List<ContractViewModel>  Contracts { get; set; }
    }
}
