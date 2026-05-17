using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Patterns
{
    public class ValidationPatterns
    {
        public const string EmailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        public const string PhonePattern = @"^\+?[0-9]{10,15}$";

        public const string NationalNoPattern = @"^[0-9]{14}$";
    }
}
