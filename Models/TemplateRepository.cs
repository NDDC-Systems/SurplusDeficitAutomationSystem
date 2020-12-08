using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class TemplateRepository : ITemplateRepository
    {
        private readonly AppDbContext context;

        public TemplateRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Template Add(Template template)
        {
            context.Templates.Add(template);
            context.SaveChanges();
            return template;
        }

        public Template Delete(int TemplateId)
        {
            Template template = context.Templates.Find(TemplateId);
            if (template != null)
            {
                context.Templates.Remove(template);
                context.SaveChanges();
            }
            return template;
        }

        public IEnumerable<Template> GetAllTemplates()
        {
            return context.Templates;
        }

        public Template GetTemplate(int TemplateId)
        {
            return context.Templates.Find(TemplateId);
        }

        public Template Update(Template templateChanges)
        {
            var report = context.Templates.Attach(templateChanges);
            report.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return templateChanges;
        }
    }
}
