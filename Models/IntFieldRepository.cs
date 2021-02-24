using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class IntFieldRepository : IIntFieldRepository
    {
        private readonly AppDbContext context;

        public IntFieldRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IntField Add(IntField intField)
        {
            context.IntFields.Add(intField);
            context.SaveChanges();
            return intField;
        }

        public IntField Delete(int IntFieldId)
        {
            IntField intField = context.IntFields.Find(IntFieldId);
            if (intField != null)
            {
                context.IntFields.Remove(intField);
                context.SaveChanges();
            }
            return intField;
        }

        public IEnumerable<IntField> GetAllIntFields()
        {
            return context.IntFields;
        }

        public IntField GetIntField(int IntFieldId)
        {
            return context.IntFields.Find(IntFieldId);
        }

        public IntField Update(IntField intFieldChanges)
        {
            var intField = context.IntFields.Attach(intFieldChanges);
            intField.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return intFieldChanges;
        }
    }
}
