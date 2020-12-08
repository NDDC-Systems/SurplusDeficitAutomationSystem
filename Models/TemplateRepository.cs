using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class TemplateRepository
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
    }
}
