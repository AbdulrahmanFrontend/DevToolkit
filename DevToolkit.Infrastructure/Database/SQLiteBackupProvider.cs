using DevToolkit.Core.Guards;
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
        public string Backup(
            DatabaseOptions options,
            string backupDirectory)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            Guard.AgainstNullOrWhiteSpace(
                options.DatabasePath,
                nameof(options.DatabasePath));

            Guard.AgainstNullOrWhiteSpace(
                backupDirectory,
                nameof(backupDirectory));

            if (!File.Exists(options.DatabasePath))
                throw new FileNotFoundException(
                    "Database file was not found.",
                    options.DatabasePath);

            Directory.CreateDirectory(backupDirectory);

            string databaseName =
                Path.GetFileNameWithoutExtension(
                    options.DatabasePath);

            string backupFileName =
                $"{databaseName}_{DateTime.Now:yyyy-MM-dd_HH-mm-ss-fff}.db";

            string backupPath =
                Path.Combine(
                    backupDirectory,
                    backupFileName);

            File.Copy(
                options.DatabasePath,
                backupPath,
                overwrite: false);

            LogManager.LogInfo($"Database backup created at: {backupPath};");

            return backupPath;
        }
    }
}
