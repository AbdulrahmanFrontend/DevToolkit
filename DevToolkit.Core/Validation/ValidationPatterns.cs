using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation
{
    public static class ValidationPatterns
    {
        public const string EmailAddress =
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        public const string PhoneNumber =
            @"^\+?[0-9()\-\s]{7,20}$";

        public const string NationalNumber =
            @"^[0-9]{14}$";
    }
}
