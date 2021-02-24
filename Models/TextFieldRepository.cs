using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class TextFieldRepository : ITextFieldRepository
    {
        private readonly AppDbContext context;

        public TextFieldRepository(AppDbContext context)
        {
            this.context = context;
        }
        public TextField Add(TextField textField)
        {
            context.TextFields.Add(textField);
            context.SaveChanges();
            return textField;
        }

        public TextField Delete(int TextFieldId)
        {
            TextField textField = context.TextFields.Find(TextFieldId);
            if (textField != null)
            {
                context.TextFields.Remove(textField);
                context.SaveChanges();
            }
            return textField;
        }

        public IEnumerable<TextField> GetAllTextFields()
        {
            return context.TextFields;
        }

        public TextField GetTextField(int TextFieldId)
        {
            return context.TextFields.Find(TextFieldId);
        }

        public TextField Update(TextField textFieldChanges)
        {
            var textField = context.TextFields.Attach(textFieldChanges);
            textField.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return textFieldChanges;
        }
    }
}
