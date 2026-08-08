using DevToolkit.Data.Core;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using DevToolkit.Logging.Managers;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    internal class SQLiteDatabaseScriptRunner : IDatabaseScriptRunner
    {
        public void Run(DatabaseOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            if (!File.Exists(options.DatabaseScriptPath))
            {
                throw new FileNotFoundException(
                    "Database script file was not found.",
                    options.DatabaseScriptPath);
            }

            string script =
                File.ReadAllText(options.DatabaseScriptPath);

            if (string.IsNullOrWhiteSpace(script))
            {
                throw new InvalidOperationException(
                    "Database script file is empty.");
            }

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
