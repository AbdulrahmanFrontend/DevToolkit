using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class MinLengthAttribute : LengthAttribute
    {
        public MinLengthAttribute(int length, string errorMessage = null) : 
            base(length, errorMessage)
        {
            this.ErrorMessage = errorMessage ?? $"Minimum Length Should Be {this.Length}.";
        }
    }
}
