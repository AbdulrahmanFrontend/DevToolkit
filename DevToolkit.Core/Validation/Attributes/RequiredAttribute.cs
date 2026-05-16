using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    public class RequiredAttribute : MainAttribute
    {
        public RequiredAttribute(string errorMessage = "Value is required.")
        {
            this.ErrorMessage = errorMessage;
        }
    }
}
