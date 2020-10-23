using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class ContractModel
    {
        public int ContractId { get; set; }
        public string ProgramId { get; set; }
        public string ProviderId { get; set; }
        public string Service { get; set; }
        public string ContractAmount { get; set; }
        public string ContractYear { get; set; }
        public string MonthlyReport { get; set; }
        public int ContractMonth { get; set; }
        public string YTDExpenditures { get; set; }
        public string PriorExpenditureRate { get; set; }
        public string Explanation { get; set; }
    }
}
