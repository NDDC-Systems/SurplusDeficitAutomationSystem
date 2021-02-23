using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IStringFieldRepository
    {
        StringField GetStringField(int StringFieldId);
        IEnumerable<StringField> GetAllStringFields();
        StringField Add(StringField stringField);
        StringField Update(StringField stringFieldChanges);
        StringField Delete(int StringFieldId);
    }
}
