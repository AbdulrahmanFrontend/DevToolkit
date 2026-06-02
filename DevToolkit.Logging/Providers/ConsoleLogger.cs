using DevToolkit.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Logging.Abstractions;
using System.Diagnostics;

namespace DevToolkit.Logging.Providers
{
    public class ConsoleLogger : ILogger
    {
        private void _Write(string message, LogLevel level, Exception ex = null)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("_____" + level.ToString() + "_____");
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]");

            Console.WriteLine($"Message: {message}");

            if (ex != null)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
        }

        public void LogError(string message, Exception ex = null) 
            => _Write(message, LogLevel.Error, ex);

        public void LogInfo(string message) => _Write(message, LogLevel.Info);


        public void LogWarning(string message) => _Write(message, LogLevel.Warning);

        public void LogDebug(string message, Exception ex = null) 
            => _Write(message, LogLevel.Debug, ex);
    }
}
