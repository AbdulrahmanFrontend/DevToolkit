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
        private static ILogger _current;

        public static void Initialize(ILogger logger)
        {
            if (_current != null)
                throw new InvalidOperationException("LogManager is already initialized.");

            _current = logger;
        }

        public static void LogError(string ErrorMessage, Exception ex) 
            => _current?.LogError(ErrorMessage, ex);

        public static void LogInfo(string InfoMessage) 
            => _current?.LogInfo(InfoMessage);

        public static void LogWarning(string WarningMessage) 
            => _current?.LogWarning(WarningMessage);

        public static void LogDebug(string DebugMessage, Exception ex = null) 
            => _current?.LogDebug(DebugMessage, ex);
    }
}
