using DevToolkit.Core.Guards;
using DevToolkit.Infrastructure.Startup;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.FileSystem
{
    public static class AppFoldersInitializer
    {
        public static AppFolders Initialize(StartupOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            if (string.IsNullOrWhiteSpace(options.ApplicationName))
            {
                throw new ArgumentException(
                    "Application name is required.",
                    nameof(options.ApplicationName));
            }

            string documents =
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments);

            string root =
                Path.Combine(documents, options.ApplicationName);

            string data =
                Path.Combine(root, "Data");

            string logs =
                Path.Combine(root, "Logs");

            string backups =
                Path.Combine(root, "Backups");

            string settings =
                Path.Combine(root, "Settings");

            Directory.CreateDirectory(root);

            Directory.CreateDirectory(data);

            Directory.CreateDirectory(logs);

            Directory.CreateDirectory(backups);

            Directory.CreateDirectory(settings);

            return new AppFolders(
                root,
                data,
                logs,
                backups,
                settings);
        }
    }
}
