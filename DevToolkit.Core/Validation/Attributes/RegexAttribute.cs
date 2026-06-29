using DevToolkit.Core.Guards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public abstract class RegexAttribute : MainAttribute
    {
        public string Pattern { get; }
        public RegexAttribute(string pattern)
        {
            this.Pattern = pattern;
        }

        public virtual bool IsValid(string value)
            => Guard.MatchesPattern(value, Pattern);
    }
}
