using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class TemplateFieldsRepository : ITemplateFieldsRepository
    {
        private readonly AppDbContext context;

        public TemplateFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public TemplateFields Add(TemplateFields templateFields)
        {
            context.TemplateFields.Add(templateFields);
            context.SaveChanges();
            return templateFields;
        }

        public TemplateFields Delete(int Id)
        {
            TemplateFields templateFields = context.TemplateFields.Find(Id);
            if (templateFields != null)
            {
                context.TemplateFields.Remove(templateFields);
                context.SaveChanges();
            }
            return templateFields;
        }

        public IEnumerable<TemplateFields> GetAllTemplateFields()
        {
            return context.TemplateFields;
        }

        public TemplateFields GetTemplateField(int Id)
        {
            return context.TemplateFields.Find(Id);
        }

        public TemplateFields Update(TemplateFields templateFieldChanges)
        {
            var templateFields = context.TemplateFields.Attach(templateFieldChanges);
            templateFields.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return templateFieldChanges;
        }
    }
}
