using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IFieldRepository
    {
        Field GetField(int FieldId);
        IEnumerable<Field> GetAllFields();
        Field Add(Field field);
        Field Update(Field fieldChanges);
        Field Delete(int FieldId);
    }
}
