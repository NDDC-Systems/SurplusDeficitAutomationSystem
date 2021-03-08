using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class BooleanFieldRepository : IBooleanFieldRepository
    {
        private readonly AppDbContext context;

        public BooleanFieldRepository(AppDbContext context)
        {
            this.context = context;
        }
        public BooleanField Add(BooleanField booleanField)
        {
            context.BooleanFields.Add(booleanField);
            context.SaveChanges();
            return booleanField;
        }

        public BooleanField Delete(int BooleanFieldId)
        {
            BooleanField booleanField = context.BooleanFields.Find(BooleanFieldId);
            if (booleanField != null)
            {
                context.BooleanFields.Remove(booleanField);
                context.SaveChanges();
            }
            return booleanField;
        }

        public IEnumerable<BooleanField> GetAllBooleanFields()
        {
            return context.BooleanFields;
        }

        public BooleanField GetBooleanField(int BooleanFieldId)
        {
            return context.BooleanFields.Find(BooleanFieldId);
        }

        public BooleanField Update(BooleanField booleanFieldChanges)
        {
            var booleanField = context.BooleanFields.Attach(booleanFieldChanges);
            booleanField.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return booleanFieldChanges;
        }
    }
}
