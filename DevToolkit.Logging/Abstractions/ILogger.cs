using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Logging.Abstractions
{
    public interface ILogger
    {
        void LogError(string message, Exception ex = null);

        void LogInfo(string message);

        void LogWarning(string message);

        void LogDebug(string message, Exception ex = null);
    }
}
