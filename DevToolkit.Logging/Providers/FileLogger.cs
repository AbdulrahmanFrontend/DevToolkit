using DevToolkit.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Common;
using System.Diagnostics;

namespace DevToolkit.Logging.Providers
{
    public class FileLogger : ILogger
    {
        private static string _LogFilePath 
            => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs", "AppLog.txt");

        static FileLogger()
        {
            string Folder = Path.GetDirectoryName(_LogFilePath);
            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);

            else if (File.Exists(_LogFilePath) && new FileInfo(_LogFilePath).Length > 5_000_000)
                File.WriteAllText(_LogFilePath, string.Empty);
        }

        private static void _Log(StreamWriter Writer, LogLevel Level, string message)
        {
            Writer.WriteLine("----------------------------------------");
            Writer.WriteLine("_____" + Level.ToString() + "_____");
            Writer.WriteLine($"[{DateTime.Now: yyyy-MM-dd HH:mm}]");
            Writer.WriteLine("Message: {0};", message);
        }

        private void _GeneralLog(string message, LogLevel Level, Exception Ex = null)
        {
            try
            {
                using (StreamWriter Writer = new StreamWriter(_LogFilePath, true))
                {
                    _Log(Writer, Level, message);
                    if (Ex != null)
                    {
                        Writer.WriteLine("Exception: {0};", Ex.Message);
                        Writer.WriteLine("Stack Trace: {0};", Ex.StackTrace);
                    }
                }
            }
            catch
            {
                //If logging fails, we silently ignore to avoid crashing the application
            }
        }

        public void LogError(string message, Exception Ex) =>
            _GeneralLog(message, LogLevel.Error, Ex);

        public void LogInfo(string message) => _GeneralLog(message, LogLevel.Info);

        public void LogWarning(string message) => _GeneralLog(message, LogLevel.Warning);

        public void LogDebug(string message, Exception ex = null) 
            => _GeneralLog(message, LogLevel.Debug, ex);
    }
}
