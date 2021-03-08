using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class TemplateToField
    {
        public int TemplateToFieldId { get; set; }
        public int TemplateId { get; set; }
        public int FieldId { get; set; }

        public virtual Template Template { get; set; }
        public virtual Field Field { get; set; }
    }
}
