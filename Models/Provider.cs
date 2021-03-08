using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class Provider
    {
        public int ProviderId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
        //public virtual ICollection<ProviderToContract> ProvidersToContracts { get; set; }
    }
}
