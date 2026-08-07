using DevToolkit.Core.Guards;
using DevToolkit.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Logging.Providers
{
    public class EventLogger : ILogger
    {
        private string _sourceName = string.Empty;
        private const string _LogName = "Application";

        public EventLogger(string sourceName)
        {
            _Initialize(sourceName);
        }

        private void _Initialize(string sourceName)
        {
            _sourceName = sourceName;

            if (!Guard.HasValue(_sourceName))
                throw new InvalidOperationException("EventLogger SourceName must be " +
                    "set before logging.");

            try
            {
                if (!EventLog.SourceExists(_sourceName))
                    EventLog.CreateEventSource(_sourceName, _LogName);
            }
            catch
            {
                //new FileLogger().LogError("Failed to initialize EventLogger.", ex);
            }
        }

        private void _Write(string message, EventLogEntryType type, Exception ex = null)
        {
            string finalMessage = $"Date & Time: {DateTime.Now: yyyy-MM-dd HH:mm}";
            finalMessage += Environment.NewLine;
            finalMessage += $"Message: {message}";

            if (ex != null)
            {
                finalMessage += Environment.NewLine;
                finalMessage += $"Exception: {ex.Message}";
                finalMessage += Environment.NewLine;
                finalMessage += $"Stack Trace: {ex.StackTrace}";
            }

            try
            {
                EventLog.WriteEntry(_sourceName, finalMessage, type);
            }
            catch
            {
                //new FileLogger().LogError("EventLogger Failed.", EventEx);
            }
        }

        public void LogError(string message, Exception ex = null) 
            => _Write(message, EventLogEntryType.Error, ex);

        public void LogInfo(string message) 
            => _Write(message, EventLogEntryType.Information);

        public void LogWarning(string message) 
            => _Write(message, EventLogEntryType.Warning);

        public void LogDebug(string message, Exception ex = null) 
            => _Write(message, EventLogEntryType.Information, ex);
    }
}
