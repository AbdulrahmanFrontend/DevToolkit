using DevToolkit.Data.Core;
using DevToolkit.Infrastructure.Startup;
using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    internal class SQLiteDatabaseScriptRunner : IDatabaseScriptRunner
    {
        public void Run()
        {
            if (StartupManager.DatabaseOptions == null)
                throw new ArgumentNullException(nameof(StartupManager.DatabaseOptions));

            if (!File.Exists(StartupManager.DatabaseOptions.DatabaseScriptPath))
            {
                throw new FileNotFoundException(
                    "Database script file was not found.",
                    StartupManager.DatabaseOptions.DatabaseScriptPath);
            }

            string script =
                File.ReadAllText(StartupManager.DatabaseOptions.DatabaseScriptPath);

            if (string.IsNullOrWhiteSpace(script))
                throw new InvalidOperationException("Database script file is empty.");

            using (SQLiteConnection connection =
                new SQLiteConnection(DataConfiguration.ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command =
                    new SQLiteCommand(script, connection))
                {
                    command.ExecuteNonQuery();

                    LogManager.LogInfo($"Database script executed successfully;");
                }
            }
        }
    }
}
