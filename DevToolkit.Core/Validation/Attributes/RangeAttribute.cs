using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class RangeAttribute : MainAttribute
    {
        public int Min { get; }
        public int Max { get; }
        public RangeAttribute(int min, int max, string errorMessage = null)
        {
            this.Min = min;
            this.Max = max;
            this.ErrorMessage = errorMessage ?? 
                $"Value must be between {this.Min} and {this.Max}.";
        }
    }
}
