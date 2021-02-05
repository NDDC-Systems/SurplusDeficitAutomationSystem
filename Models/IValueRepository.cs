using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IValueRepository
    {
        Value GetValue(int ValueId);
        IEnumerable<Value> GetAllValues();
        Value Add(Value value);
        Value Update(Value valueChanges);
        Value Delete(int ValueId);
    }
}
