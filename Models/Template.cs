using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class Template
    {
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<TemplateToField> TemplatesToFields { get; set; }
        public virtual ICollection<TemplateFields> TemplateFields { get; set; }
    }
}
