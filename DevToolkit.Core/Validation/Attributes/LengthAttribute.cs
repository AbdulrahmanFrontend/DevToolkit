using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class LengthAttribute : MainAttribute
    {
        public int Length { get; }
        public LengthAttribute(int length, string errorMessage = null)
        {
            this.Length = length;
            this.ErrorMessage = errorMessage ?? $"Length Should Be {this.Length}.";
        }
    }
}
