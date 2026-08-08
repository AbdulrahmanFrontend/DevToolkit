using DevToolkit.Infrastructure.Database;
using DevToolkit.Infrastructure.FileSystem;
using DevToolkit.Logging.Managers;
using DevToolkit.Logging.Providers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Startup
{
    public class StartupManager
    {
        public static AppFolders Folders { get; private set; }

        public static StartupOptions StartupOptions { get; private set; }

        public static DatabaseOptions DatabaseOptions { get; private set; }

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

            StartupOptions = startupOptions;
            DatabaseOptions = databaseOptions;

            Folders = AppFoldersInitializer.Initialize();

            InitializeLogging();

            DatabaseInitializer.Initialize();

            _initialized = true;
        }

        private static void InitializeLogging()
        {
            if (StartupOptions.EnableFileLogging && !StartupOptions.EnableEventLogging)
            {
                LogManager.Initialize(new FileLogger(Path.Combine(Folders.Logs)));
            }

            if (StartupOptions.EnableEventLogging && !StartupOptions.EnableFileLogging)
            {
                LogManager.Initialize(new EventLogger(StartupOptions.EventSourceName));
            }

            if (StartupOptions.EnableEventLogging && StartupOptions.EnableFileLogging)
            {
                LogManager.Initialize(
                    new CompositeLogger(
                        new FileLogger(Path.Combine(Folders.Logs)),
                        new EventLogger(StartupOptions.EventSourceName)));
            }
        }
    }
}
