using DevToolkit.Core.Validation.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class NationalNoAttribute : RegexAttribute
    {
        public NationalNoAttribute(string errorMessage = "Invalid National Number")
             : base(ValidationPatterns.NationalNoPattern)
        {
            this.ErrorMessage = errorMessage;
        }
    }
}
