using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class ProviderToContract
    {
        public int ProviderToContractId { get; set; }
        public int ProviderId { get; set; }
        public int ContractId { get; set; }

        public virtual Provider Provider { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
