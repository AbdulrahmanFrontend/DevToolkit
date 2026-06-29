using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class EmailAddrAttribute : RegexAttribute
    {
        public EmailAddrAttribute(string errorMessage = "Invalid Email Address") 
            : base(ValidationPatterns.EmailAddress)
        {
            this.ErrorMessage = errorMessage;
        }
    }
}
