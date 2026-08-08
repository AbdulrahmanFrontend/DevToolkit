using DevToolkit.Infrastructure.FileSystem;
using DevToolkit.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    public class DatabaseBackupManager
    {
        public static string Backup(
            DatabaseOptions options,
            AppFolders folders)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            if (folders == null)
                throw new ArgumentNullException(nameof(folders));

            IDatabaseBackupProvider provider =
                CreateProvider(options.Provider);

            return provider.Backup(
                options,
                folders.Backups);
        }

        private static IDatabaseBackupProvider CreateProvider(
            DbProviderFactory.DbProvider provider)
        {
            switch (provider)
            {
                case DbProviderFactory.DbProvider.SQLite:
                    return new SQLiteBackupProvider();

                default:
                    throw new NotSupportedException(
                        $"Backup provider for '{provider}' is not supported.");
            }
        }
    }
}
