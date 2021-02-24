using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface ITextFieldRepository
    {
        TextField GetTextField(int TextFieldId);
        IEnumerable<TextField> GetAllTextFields();
        TextField Add(TextField textField);
        TextField Update(TextField textFieldChanges);
        TextField Delete(int TextFieldId);
    }
}
