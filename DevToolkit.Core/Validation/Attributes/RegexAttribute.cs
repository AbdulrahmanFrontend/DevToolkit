using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    public class RegexAttribute : MainAttribute
    {
        public string Pattern { get; }
        public RegexAttribute(string pattern, string errorMessage)
        {
            this.Pattern = pattern;
            this.ErrorMessage = errorMessage;
        }
    }
}
