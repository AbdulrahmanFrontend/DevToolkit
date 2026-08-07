using DevToolkit.Infrastructure.Database;
using DevToolkit.Infrastructure.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Startup
{
    public class StartupManager
    {
        internal static AppFolders Folders { get; private set; }

        private static bool _initialized;

        public static void Initialize(
            StartupOptions startupOptions,
            DatabaseOptions databaseOptions)
        {
            if (_initialized)
                throw new InvalidOperationException(
                    "StartupManager has already been initialized.");

            if (Folders != null)
                return;

            Folders =
                AppFoldersInitializer.Initialize(startupOptions);

            DatabaseInitializer.Initialize(
                databaseOptions,
                Folders);

            InitializeLogging(startupOptions);

            _initialized = true;
        }

        private static void InitializeLogging(
            StartupOptions options)
        {
            if (options.EnableFileLogging)
            {
                //...
            }

            if (options.EnableEventLogging)
            {
                //...
            }
        }
    }
}
