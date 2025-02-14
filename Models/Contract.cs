﻿using System;
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
        public int? ProviderId { get; set; }
        public string ContractName { get; set; }
        public float Balance { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
        public virtual Provider Provider { get; set; }
        //public virtual ICollection<ProviderToContract> ProvidersToContracts { get; set; }

    }
}
