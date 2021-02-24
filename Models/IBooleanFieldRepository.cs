using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IBooleanFieldRepository
    {
        BooleanField GetBooleanField(int BooleanFieldId);
        IEnumerable<BooleanField> GetAllBooleanFields();
        BooleanField Add(BooleanField booleanField);
        BooleanField Update(BooleanField booleanFieldChanges);
        BooleanField Delete(int BooleanFieldId);
    }
}
