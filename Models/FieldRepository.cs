using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class FieldRepository
    {
        private readonly AppDbContext context;

        public FieldRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Field Add(Field field)
        {
            context.Fields.Add(field);
            context.SaveChanges();
            return field;
        }

        public Field Delete(int FieldId)
        {
            Field field = context.Fields.Find(FieldId);
            if (field != null)
            {
                context.Fields.Remove(field);
                context.SaveChanges();
            }
            return field;
        }

        public IEnumerable<Field> GetAllReports()
        {
            return context.Fields;
        }

        public Field GetReport(int FieldId)
        {
            return context.Fields.Find(FieldId);
        }

        public Field Update(Field fieldChanges)
        {
            var field = context.Fields.Attach(fieldChanges);
            field.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return fieldChanges;
        }
    }
}
