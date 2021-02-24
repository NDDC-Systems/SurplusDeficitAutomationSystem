using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IIntFieldRepository
    {
        IntField GetIntField(int IntFieldId);
        IEnumerable<IntField> GetAllIntFields();
        IntField Add(IntField intField);
        IntField Update(IntField intFieldChanges);
        IntField Delete(int IntFieldId);
    }
}
