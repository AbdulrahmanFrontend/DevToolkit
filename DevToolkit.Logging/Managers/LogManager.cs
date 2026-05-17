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
        private static ILogger _Current { get; set; }

        public static void LogError(string ErrorMessage, Exception ex)
        {
            _Current?.LogError(ErrorMessage, ex);
        }

        public static void LogInfo(string InfoMessage)
        {
            _Current?.LogInfo(InfoMessage);
        }

        public static void LogWarning(string WarningMessage)
        {
            _Current?.LogWarning(WarningMessage);
        }
    }
}
