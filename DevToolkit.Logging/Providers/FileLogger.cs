using DevToolkit.Core.Common;
using DevToolkit.Core.Guards;
using DevToolkit.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Logging.Providers
{
    public class FileLogger : ILogger
    {
        private readonly string _logFilePath = string.Empty;

        public FileLogger(string logFilePath)
        {
            Guard.AgainstNullOrWhiteSpace(logFilePath, nameof(logFilePath));

            _logFilePath = Path.Combine(
                logFilePath,
                $"{DateTime.Today:yyyy-MM-dd}.log");

            Initialize();
        }

        private void Initialize()
        {
            if (!File.Exists(_logFilePath))
            {
                string Folder = Path.GetDirectoryName(_logFilePath);
                Directory.CreateDirectory(Folder);
                File.Create(_logFilePath).Dispose();
            }

            FileInfo file = new FileInfo(_logFilePath);

            if (file.Length > 10 * 1024 * 1024) // 10 MB
                File.WriteAllText(_logFilePath, string.Empty);
        }

        private static void _WriteHeader(
            StreamWriter Writer,
            LogLevel Level, 
            string message)
        {
            Writer.WriteLine("----------------------------------------");
            Writer.WriteLine("_____" + Level.ToString() + "_____");
            Writer.WriteLine($"[{DateTime.Now: yyyy-MM-dd HH:mm}]");
            Writer.WriteLine("Message: {0}", message);
        }

        private void _Write(string message, LogLevel Level, Exception Ex = null)
        {
            try
            {
                using (StreamWriter Writer = new StreamWriter(_logFilePath, true))
                {
                    _WriteHeader(Writer, Level, message);
                    if (Ex != null)
                    {
                        Writer.WriteLine("Exception: {0}", Ex.Message);
                        Writer.WriteLine("Stack Trace: {0}", Ex.StackTrace);
                    }
                }
            }
            catch
            {
                //If logging fails, we silently ignore to avoid crashing the application
            }
        }

        public void LogError(string message, Exception Ex) =>
            _Write(message, LogLevel.Error, Ex);

        public void LogInfo(string message) => _Write(message, LogLevel.Info);

        public void LogWarning(string message) => _Write(message, LogLevel.Warning);

        public void LogDebug(string message, Exception ex = null) 
            => _Write(message, LogLevel.Debug, ex);
    }
}
