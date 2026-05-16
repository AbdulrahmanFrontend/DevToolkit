using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    public class EmailAttribute : MainAttribute
    {
        public EmailAttribute(string errorMessage = "Invalid Email Format.")
        {
            ErrorMessage = errorMessage;
        }
    }
}
