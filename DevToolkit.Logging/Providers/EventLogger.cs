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
        public static string SourceName { get; set; } = string.Empty;
        private const string _LogName = "Application";

        private static bool _initialized = false;

        private static void _Initialize()
        {
            if (_initialized)
                return;

            if (!Guard.HasValue(SourceName))
                throw new InvalidOperationException("EventLogger SourceName must be set before" +
                    " logging.");

            try
            {
                if (!EventLog.SourceExists(SourceName))
                    EventLog.CreateEventSource(SourceName, _LogName);

                _initialized = true;
            }
            catch(Exception ex)
            {
                new FileLogger().LogError("Failed to initialize EventLogger.", ex);
            }
        }

        private void _Write(string message, EventLogEntryType type, Exception ex = null)
        {
            _Initialize();

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
                EventLog.WriteEntry(SourceName, finalMessage, type);
            }
            catch(Exception EventEx)
            {
                new FileLogger().LogError("EventLogger Failed.", EventEx);
            }
        }

        public void LogError(string message, Exception ex = null) 
            => _Write(message, EventLogEntryType.Error, ex);

        public void LogInfo(string message) => _Write(message, EventLogEntryType.Information);

        public void LogWarning(string message) => _Write(message, EventLogEntryType.Warning);

        public void LogDebug(string message, Exception ex = null) 
            => _Write(message, EventLogEntryType.Information, ex);
    }
}
