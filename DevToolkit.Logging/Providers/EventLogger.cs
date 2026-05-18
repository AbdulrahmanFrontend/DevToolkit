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
        public static string SourceName = string.Empty;
        private const string _LogName = "Application";

        static EventLogger()
        {
            if (!Guard.HasValue(SourceName))
            {
                SourceName = "DevToolkit";
            }
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(
                    SourceName,
                    _LogName);
            }
        }

        private void _Write(
            string message,
            EventLogEntryType type,
            Exception ex = null)
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

            EventLog.WriteEntry(
                SourceName,
                finalMessage,
                type);
        }

        public void LogError(string message, Exception ex = null)
        {
            _Write(message, EventLogEntryType.Error, ex);
        }

        public void LogInfo(string message)
        {
            _Write(message, EventLogEntryType.Information);
        }

        public void LogWarning(string message)
        {
            _Write(message, EventLogEntryType.Warning);
        }

        public void LogDebug(string message, Exception ex = null)
        {
            _Write(message, EventLogEntryType.Information, ex);
        }
    }
}
