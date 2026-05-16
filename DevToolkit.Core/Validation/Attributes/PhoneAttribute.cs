using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    public class PhoneAttribute : MainAttribute
    {
        public PhoneAttribute(string errorMessage = "Invalid Phone Number Format.")
        {
            this.ErrorMessage = errorMessage;
        }
    }
}
