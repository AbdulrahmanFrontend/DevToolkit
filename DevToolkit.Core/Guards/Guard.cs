using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Guards
{
    public class Guard
    {
        public static bool HasValue(string Value)
            => Value != string.Empty && !string.IsNullOrWhiteSpace(Value);
    }
}
