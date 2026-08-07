using DevToolkit.Core.Guards;
using DevToolkit.Data.Core;
using DevToolkit.Infrastructure.FileSystem;
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
        public void EnsureCreated(DatabaseOptions options, AppFolders folders)
        {
            Validate(options, folders);

            BuildDatabasePath(options, folders);

            ConfigureData(options);

            CreateDatabase(options);
        }

        private static void Validate(DatabaseOptions options, AppFolders folders)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            if (folders == null)
                throw new ArgumentNullException(nameof(folders));

            Guard.AgainstNullOrWhiteSpace(
                options.DatabaseName, 
                nameof(options.DatabaseName));
        }

        private static void BuildDatabasePath(
            DatabaseOptions options, 
            AppFolders folders)
        {
            string databaseName = Path.GetFileNameWithoutExtension(options.DatabaseName);

            options.DatabasePath = Path.Combine(folders.Data, databaseName + ".db");
        }

        private static void ConfigureData(DatabaseOptions options)
        {
            DataConfiguration.Configure(
                $"Data Source={options.DatabasePath};" +
                $"Foreign Keys=True;" +
                $"BusyTimeout=5000;");
        }

        private static void CreateDatabase(DatabaseOptions options)
        {
            if (!options.CreateIfNotExists)
                return;

            if (File.Exists(options.DatabasePath))
                return;

            SQLiteConnection.CreateFile(options.DatabasePath);
        }
    }
}
