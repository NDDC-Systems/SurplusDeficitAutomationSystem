using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class TextField
    {
        public int TextFieldId { get; set; }
        [ForeignKey("Field")]
        public int FieldId { get; set; }
        public string TextValue { get; set; }

        public virtual Field Field { get; set; }
    }
}
