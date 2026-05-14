using DevToolkit.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Logging.Managers
{
    public class LogManager
    {
        public static ILogger Current { get; set; }
    }
}
