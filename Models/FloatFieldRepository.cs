using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class FloatFieldRepository : IFloatFieldRepository
    {
        private readonly AppDbContext context;

        public FloatFieldRepository(AppDbContext context)
        {
            this.context = context;
        }
        public FloatField Add(FloatField floatField)
        {
            context.FloatFields.Add(floatField);
            context.SaveChanges();
            return floatField;
        }

        public FloatField Delete(int FloatFieldId)
        {
            FloatField floatField = context.FloatFields.Find(FloatFieldId);
            if (floatField != null)
            {
                context.FloatFields.Remove(floatField);
                context.SaveChanges();
            }
            return floatField;
        }

        public IEnumerable<FloatField> GetAllFloatFields()
        {
            return context.FloatFields;
        }

        public FloatField GetFloatField(int FloatFieldId)
        {
            return context.FloatFields.Find(FloatFieldId);
        }

        public FloatField Update(FloatField floatFieldChanges)
        {
            var floatField = context.FloatFields.Attach(floatFieldChanges);
            floatField.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return floatFieldChanges;
        }
    }
}
