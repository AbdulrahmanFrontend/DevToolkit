using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Validation.Attributes;

namespace DevToolkit.Core.Common
{
    public abstract class BaseEntity
    {
        [Required]
        public int ID { get; set; }
    }
}
