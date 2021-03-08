using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class DateTimeFieldRepository : IDateTimeFieldRepository
    {
        private readonly AppDbContext context;

        public DateTimeFieldRepository(AppDbContext context)
        {
            this.context = context;
        }
        public DateTimeField Add(DateTimeField dateTimeField)
        {
            context.DateTimeFields.Add(dateTimeField);
            context.SaveChanges();
            return dateTimeField;
        }

        public DateTimeField Delete(int DateTimeFieldId)
        {
            DateTimeField dateTimeField = context.DateTimeFields.Find(DateTimeFieldId);
            if (dateTimeField != null)
            {
                context.DateTimeFields.Remove(dateTimeField);
                context.SaveChanges();
            }
            return dateTimeField;
        }

        public IEnumerable<DateTimeField> GetAllDateTimeFields()
        {
            return context.DateTimeFields;
        }

        public DateTimeField GetDateTimeField(int DateTimeFieldId)
        {
            return context.DateTimeFields.Find(DateTimeFieldId);
        }

        public DateTimeField Update(DateTimeField dateTimeFieldChanges)
        {
            var dateTimeField = context.DateTimeFields.Attach(dateTimeFieldChanges);
            dateTimeField.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return dateTimeFieldChanges;
        }
    }
}
