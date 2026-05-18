using DevToolkit.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Logging.Providers
{
    public class CompositeLogger : ILogger
    {
        private readonly List<ILogger> _loggers;

        public CompositeLogger(ILogger[] loggers)
        {
            _loggers = loggers?.ToList() ?? new List<ILogger>();
        }

        public void LogError(string message, Exception ex = null)
        {
            foreach (var logger in _loggers)
            {
                logger.LogError(message, ex);
            }
        }

        public void LogInfo(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.LogInfo(message);
            }
        }

        public void LogWarning(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.LogWarning(message);
            }
        }

        public void LogDebug(string message, Exception ex = null)
        {
            foreach (var logger in _loggers)
            {
                logger.LogDebug(message, ex);
            }
        }
    }
}
