using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IValuesRepository
    {
        Values GetValue(int ValueId);
        Values Add(Values value);
        Values Update(Values valueChanges);
        Values Delete(int ValueId);
    }
}
