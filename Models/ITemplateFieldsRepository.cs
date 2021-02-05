using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface ITemplateFieldsRepository
    {
        TemplateFields GetTemplateField(int Id);
        IEnumerable<TemplateFields> GetAllTemplateFields();
        TemplateFields Add(TemplateFields templateField);
        TemplateFields Update(TemplateFields templateFieldChanges);
        TemplateFields Delete(int Id);
    }
}
