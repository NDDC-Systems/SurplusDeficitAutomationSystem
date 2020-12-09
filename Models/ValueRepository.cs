using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class ValueRepository : IValueRepository
    {
        private readonly AppDbContext context;

        public ValueRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Value Add(Value value)
        {
            context.Values.Add(value);
            context.SaveChanges();
            return value;
        }

        public Value Delete(int ValueId)
        {
            Value value = context.Values.Find(ValueId);
            if (value != null)
            {
                context.Values.Remove(value);
                context.SaveChanges();
            }
            return value;
        }

        public IEnumerable<Value> GetAllValues()
        {
            return context.Values;
        }

        public Value GetValue(int ValueId)
        {
            return context.Values.Find(ValueId);
        }

        public Value Update(Value valueChanges)
        {
            var value = context.Values.Attach(valueChanges);
            value.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return valueChanges;
        }
    }
}
