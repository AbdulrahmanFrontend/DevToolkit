using DevToolkit.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private enum _enLogBehavior
        {
            ERROR,
            INFO,
            WARNING
        }
        private static void _Log(StreamWriter Writer, _enLogBehavior Bahavior,
            string message)
        {
            Writer.WriteLine("----------------------------------------");
            Writer.WriteLine("_____" + Bahavior.ToString() + "_____");
            Writer.WriteLine($"Date & Time: [{DateTime.Now: yyyy-MM-dd HH:mm}] ");
            Writer.WriteLine("Message: {0};", message);
        }
        private static void _GeneralLog(string message, _enLogBehavior Behavior,
            Exception Ex = null)
        {
            try
            {
                using (StreamWriter Writer = new StreamWriter(_LogFilePath, true))
                {
                    _Log(Writer, Behavior, message);
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
            _GeneralLog(message, _enLogBehavior.ERROR, Ex);
        }
        public void LogInfo(string message)
        {
            _GeneralLog(message, _enLogBehavior.INFO);
        }
        public void LogWarning(string message)
        {
            _GeneralLog(message, _enLogBehavior.WARNING);
        }
    }
}
