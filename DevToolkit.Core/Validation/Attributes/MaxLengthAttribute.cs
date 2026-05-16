using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    public class MaxLengthAttribute : LengthAttribute
    {
        public MaxLengthAttribute(int length, string errorMessage = null) :
            base(length, errorMessage)
        {
            this.ErrorMessage = errorMessage ?? $"Maximum Length Should Be {this.Length}.";
        }
    }
}
