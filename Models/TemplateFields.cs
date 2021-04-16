using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class TemplateFields
    {
        public int Id { get; set; }
        [ForeignKey("Template")]
        public int TemplateId { get; set; }
        [ForeignKey("Field")]
        public int FieldId { get; set; }

        public virtual Template Template { get; set; }
        public virtual Field Field { get; set; }
    }
}
