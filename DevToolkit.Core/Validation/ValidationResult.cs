using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Validation
{
    public class ValidationResult
    {
        public List<ValidationError> Errors { get; set; } = 
            new List<ValidationError>();

        public bool IsValid => !Errors.Any();
    }
}
