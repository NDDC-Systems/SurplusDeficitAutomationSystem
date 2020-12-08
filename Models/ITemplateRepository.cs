using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface ITemplateRepository
    {
        Template GetTemplate(int TemplateId);
        IEnumerable<Template> GetAllTemplates();
        Template Add(Template template);
        Template Update(Template templateChanges);
        Template Delete(int id);
    }
}
