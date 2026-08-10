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
    internal static class AppFoldersInitializer
    {
        public static AppFolders Initialize()
        {
            if (StartupManager.StartupOptions == null)
                throw new ArgumentNullException(
                    nameof(StartupManager.StartupOptions));

            if (string.IsNullOrWhiteSpace(
                StartupManager.StartupOptions.ApplicationName))
            {
                throw new ArgumentException(
                    "Application name is required.",
                    nameof(StartupManager.StartupOptions.ApplicationName));
            }

            string documents = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);

            string root = Path.Combine(
                documents, 
                StartupManager.StartupOptions.ApplicationName);

            string data = Path.Combine(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                StartupManager.StartupOptions.ApplicationName), "Data");

            string logs = Path.Combine(root, "Logs");

            string backups = Path.Combine(root, "Backups");

            string settings = Path.Combine(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                StartupManager.StartupOptions.ApplicationName), "Settings");

            string prints = Path.Combine(root, "Prints");

            Directory.CreateDirectory(root);

            Directory.CreateDirectory(data);

            Directory.CreateDirectory(logs);

            Directory.CreateDirectory(backups);

            Directory.CreateDirectory(settings);

            Directory.CreateDirectory(prints);

            return new AppFolders(
                root,
                data,
                logs,
                backups,
                settings,
                prints);
        }
    }
}
