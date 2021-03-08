using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class StringFieldRepository : IStringFieldRepository
    {
        private readonly AppDbContext context;

        public StringFieldRepository(AppDbContext context)
        {
            this.context = context;
        }
        public StringField Add(StringField stringField)
        {
            context.StringFields.Add(stringField);
            context.SaveChanges();
            return stringField;
        }

        public StringField Delete(int StringFieldId)
        {
            StringField stringField = context.StringFields.Find(StringFieldId);
            if (stringField != null)
            {
                context.StringFields.Remove(stringField);
                context.SaveChanges();
            }
            return stringField;
        }

        public IEnumerable<StringField> GetAllStringFields()
        {
            return context.StringFields;
        }

        public StringField GetStringField(int StringFieldId)
        {
            return context.StringFields.Find(StringFieldId);
        }

        public StringField Update(StringField stringFieldChanges)
        {
            var stringField = context.StringFields.Attach(stringFieldChanges);
            stringField.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return stringFieldChanges;
        }
    }
}
