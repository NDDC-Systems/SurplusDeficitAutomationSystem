using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class StringField
    {
        public int StringFieldId { get; set; }
        [ForeignKey("Field")]
        public int FieldId { get; set; }
        public string StringValue { get; set; }

        public virtual Field Field { get; set; }
    }
}
