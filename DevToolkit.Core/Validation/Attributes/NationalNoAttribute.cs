using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    public class NationalNoAttribute : MainAttribute
    {
        public NationalNoAttribute(string errorMessage = "Invalid National Number Format.")
        {
            this.ErrorMessage = errorMessage;
        }
    }
}
