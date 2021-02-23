using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class ProviderViewModel
    {
        public int ProviderId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        //public List<ContractViewModel> Contracts { get; set; }
    }
}
