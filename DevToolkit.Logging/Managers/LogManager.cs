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

        public static void LogError(string ErrorMessage, Exception ex)
        {
            Current?.LogError(ErrorMessage, ex);
        }

        public static void LogInfo(string InfoMessage)
        {
            Current?.LogInfo(InfoMessage);
        }

        public static void LogWarning(string WarningMessage)
        {
            Current?.LogWarning(WarningMessage);
        }
        public static void LogDebug(string DebugMessage, Exception ex = null)
        {
            Current?.LogDebug(DebugMessage, ex);
        }
    }
}
