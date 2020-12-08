using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class ReportFieldValues
    {
        public int Id { get; set; }
        [ForeignKey("Report")]
        public int ReportId { get; set; }
        [ForeignKey("Field")]
        public int FieldId { get; set; }
        [ForeignKey("Values")]
        public int ValueId { get; set; }
    }
}
