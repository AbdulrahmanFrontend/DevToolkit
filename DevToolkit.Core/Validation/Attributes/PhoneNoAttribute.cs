using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class PhoneNoAttribute : RegexAttribute
    {
        public PhoneNoAttribute(string errorMessage = "Invalid Phone Number")
             : base(ValidationPatterns.NationalNumber)
        {
            this.ErrorMessage = errorMessage;
        }
    }
}
