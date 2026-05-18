using DevToolkit.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Common;

namespace DevToolkit.Logging.Providers
{
    public class FileLogger : ILogger
    {
        private static string _LogFilePath
        {
            get
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs",
                    "AppLog.txt");
            }
        }
        static FileLogger()
        {
            string Folder = Path.GetDirectoryName(_LogFilePath);
            if (!Directory.Exists(Folder))
            {
                Directory.CreateDirectory(Folder);
            }
            if (File.Exists(_LogFilePath) &&
                new FileInfo(_LogFilePath).Length > 5_000_000)
            {
                File.Delete(_LogFilePath);
            }
        }
        private static void _Log(StreamWriter Writer, Enums.LogLevel Level,
            string message)
        {
            Writer.WriteLine("----------------------------------------");
            Writer.WriteLine("_____" + Level.ToString() + "_____");
            Writer.WriteLine($"Date & Time: [{DateTime.Now: yyyy-MM-dd HH:mm}] ");
            Writer.WriteLine("Message: {0};", message);
        }
        private void _GeneralLog(string message, Enums.LogLevel Level,
            Exception Ex = null)
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
        public void LogError(string message, Exception Ex)
        {
            _GeneralLog(message, Enums.LogLevel.Error, Ex);
        }
        public void LogInfo(string message)
        {
            _GeneralLog(message, Enums.LogLevel.Info);
        }
        public void LogWarning(string message)
        {
            _GeneralLog(message, Enums.LogLevel.Warning);
        }
    }
}
