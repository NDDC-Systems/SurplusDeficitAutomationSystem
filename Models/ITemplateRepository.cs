using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    interface ITemplateRepository
    {
        Template GetTemplate(int ReportId);
        IEnumerable<Template> GetAllTemplates();
        Report Add(Report report);
    }
}
