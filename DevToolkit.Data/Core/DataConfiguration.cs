using DevToolkit.Core.Guards;
using DevToolkit.Data.Executors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Core
{
    public static class DataConfiguration
    {
        public static string DatabaseFilePath
        {
            get
            {
                SQLiteConnectionStringBuilder builder =
                    new SQLiteConnectionStringBuilder(ConnectionString);

                string databasePath = builder.DataSource;

                if (databasePath.StartsWith("|DataDirectory|",
                    StringComparison.OrdinalIgnoreCase))
                {
                    databasePath = databasePath.Replace(
                        "|DataDirectory|",
                        AppDomain.CurrentDomain.GetData("DataDirectory")?.ToString()
                        ?? AppDomain.CurrentDomain.BaseDirectory);
                }

                return Path.GetFullPath(databasePath);
            }
        }

        public static string ConnectionString { get; private set; }

        public static void Configure(string connectionString)
        {
            Guard.AgainstNullOrWhiteSpace(
                connectionString, 
                nameof(connectionString));

            ConnectionString = connectionString;
        }
    }
}
