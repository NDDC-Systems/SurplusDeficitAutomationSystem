using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        [ForeignKey("Template")]
        public int TemplateId { get; set; }
        [ForeignKey("Contract")]
        public int ContractId { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        [Required]
        public DateTime SubmitDate { get; set; }
        public bool Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual Template Template { get; set; }
        public virtual Admin Admin { get; set; }
    }
}