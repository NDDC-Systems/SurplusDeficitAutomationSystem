using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class Contract
    {
        public int ContractId { get; set; }
        [ForeignKey("Template")]
        public int TemplateId { get; set; }
        [ForeignKey("Provider")]
        public int ProviderId { get; set; }
        public float Balance { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
        //public virtual ICollection<ReportToContract> ReportsToContracts { get; set; }

    }
}
