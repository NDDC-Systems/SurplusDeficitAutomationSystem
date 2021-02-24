using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IFloatFieldRepository
    {
        FloatField GetFloatField(int FloatFieldId);
        IEnumerable<FloatField> GetAllFloatFields();
        FloatField Add(FloatField floatField);
        FloatField Update(FloatField floatFieldChanges);
        FloatField Delete(int FloatFieldId);
    }
}
