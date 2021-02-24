using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class DateTimeField
    {
        public int DateTimeFieldId { get; set; }
        [ForeignKey("Field")]
        public int FieldId { get; set; }
        public DateTime DateTimeValue { get; set; }

        public virtual Field Field { get; set; }
    }
}
