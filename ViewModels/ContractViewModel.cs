using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.ViewModels
{
    public class ContractViewModel
    {
        public int ContractId { get; set; }
        public int TemplateId { get; set; }
        public int ProviderId { get; set; }
        public float Balance { get; set; }
    }
}
