using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IDateTimeFieldRepository
    {
        DateTimeField GetDateTimeField(int DateTimeFieldId);
        IEnumerable<DateTimeField> GetAllDateTimeFields();
        DateTimeField Add(DateTimeField dateTimeField);
        DateTimeField Update(DateTimeField dateTimeFieldChanges);
        DateTimeField Delete(int DateTimeFieldId);
    }
}
