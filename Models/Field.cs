using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class Field
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public virtual ICollection<TemplateFields> TemplateFields { get; set; }
        public virtual ICollection<TemplateToField> TemplatesToFields { get; set; }
        public virtual ICollection<StringField> StringFields { get; set; }
        public virtual ICollection<IntField> IntFields { get; set; }
        public virtual ICollection<BooleanField> BooleanFields { get; set; }
        public virtual ICollection<TextField> TextFields { get; set; }
        public virtual ICollection<DateTimeField> DateTimeFields { get; set; }
        public virtual ICollection<FloatField> FloatFields { get; set; }
    }
}
