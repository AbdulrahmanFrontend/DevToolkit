using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Common;

namespace DevToolkit.Logging.Models
{
    public class LogEntry
    {
        public DateTime TimeStamp { get; set; }

        public LogLevel Level { get; set; }

        public string Message { get; set; }

        public Exception Exception { get; set; }
    }
}
