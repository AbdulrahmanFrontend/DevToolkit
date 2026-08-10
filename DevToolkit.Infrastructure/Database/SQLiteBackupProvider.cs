using DevToolkit.Core.Guards;
using DevToolkit.Core.Results;
using DevToolkit.Infrastructure.Startup;
using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    internal class SQLiteBackupProvider : IDatabaseBackupProvider
    {
        public string Backup(string databaseName)
        {
            if (StartupManager.DatabaseOptions == null)
                throw new ArgumentNullException(nameof(StartupManager.DatabaseOptions));

            Guard.AgainstNullOrWhiteSpace(
                StartupManager.DatabaseOptions.DatabasePath,
                nameof(StartupManager.DatabaseOptions.DatabasePath));

            Guard.AgainstNullOrWhiteSpace(
                StartupManager.Folders.Backups,
                nameof(StartupManager.Folders.Backups));

            if (!File.Exists(StartupManager.DatabaseOptions.DatabasePath))
                throw new FileNotFoundException(
                    "Database file was not found.",
                    StartupManager.DatabaseOptions.DatabasePath);

            Directory.CreateDirectory(StartupManager.Folders.Backups);

            string backupFileName = $"{databaseName}.db";

            string backupPath = Path.Combine(
                StartupManager.Folders.Backups,
                backupFileName);

            File.Copy(StartupManager.DatabaseOptions.DatabasePath, backupPath, true);

            LogManager.LogInfo($"Database backup created at: {backupPath};");

            return backupPath;
        }
    }
}
