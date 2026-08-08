using DevToolkit.Core.Guards;
using DevToolkit.Data.Core;
using DevToolkit.Infrastructure.FileSystem;
using DevToolkit.Infrastructure.Startup;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    internal class SQLiteDatabaseProvider : IDatabaseProvider
    {
        public bool EnsureCreated()
        {
            Validate();

            BuildDatabasePath();

            ConfigureData();

            return CreateDatabase();
        }

        private static void Validate()
        {
            if (StartupManager.DatabaseOptions == null)
                throw new ArgumentNullException(nameof(StartupManager.DatabaseOptions));

            if (StartupManager.Folders == null)
                throw new ArgumentNullException(nameof(StartupManager.Folders));

            Guard.AgainstNullOrWhiteSpace(
                StartupManager.DatabaseOptions.DatabaseName, 
                nameof(StartupManager.DatabaseOptions.DatabaseName));
        }

        private static void BuildDatabasePath()
        {
            string databaseName = Path.GetFileNameWithoutExtension(
                StartupManager.DatabaseOptions.DatabaseName);

            StartupManager.DatabaseOptions.DatabasePath = Path.Combine(
                StartupManager.Folders.Data, 
                databaseName + ".db");
        }

        private static void ConfigureData()
        {
            DataConfiguration.Configure(
                $"Data Source={StartupManager.DatabaseOptions.DatabasePath};" +
                $"Foreign Keys=True;" +
                $"BusyTimeout=5000;");
        }

        private static bool CreateDatabase()
        {
            if (!StartupManager.DatabaseOptions.CreateIfNotExists)
                return false;

            if (File.Exists(StartupManager.DatabaseOptions.DatabasePath))
                return false;

            SQLiteConnection.CreateFile(StartupManager.DatabaseOptions.DatabasePath);

            return true;
        }
    }
}
