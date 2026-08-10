using DevToolkit.Core.Results;
using DevToolkit.Data.Core;
using DevToolkit.Infrastructure.FileSystem;
using DevToolkit.Infrastructure.Startup;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    public class DatabaseBackupManager
    {
        public static string Backup(string databaseName)
        {
            if (StartupManager.DatabaseOptions == null)
                throw new ArgumentNullException(nameof(StartupManager.DatabaseOptions));

            if (StartupManager.DatabaseOptions == null)
                throw new ArgumentNullException(nameof(StartupManager.DatabaseOptions));

            IDatabaseBackupProvider provider = CreateProvider();

            return provider.Backup(databaseName);
        }

        private static IDatabaseBackupProvider CreateProvider()
        {
            switch (StartupManager.DatabaseOptions.Provider)
            {
                case DbProviderFactory.DbProvider.SQLite:
                    return new SQLiteBackupProvider();

                default:
                    throw new NotSupportedException(
                        $"Backup provider for " +
                        $"'{StartupManager.DatabaseOptions.Provider}' is not supported.");
            }
        }
    }
}
