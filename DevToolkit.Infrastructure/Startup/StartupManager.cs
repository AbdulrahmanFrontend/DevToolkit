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

            InitializeLogging(startupOptions);

            DatabaseInitializer.Initialize(
                databaseOptions,
                Folders);

            _initialized = true;
        }

        private static void InitializeLogging(
            StartupOptions options)
        {
            if (options.EnableFileLogging && !options.EnableEventLogging)
            {
                LogManager.Initialize(new FileLogger(Path.Combine(Folders.Logs)));
            }

            if (options.EnableEventLogging && !options.EnableFileLogging)
            {
                LogManager.Initialize(new EventLogger(options.EventSourceName));
            }

            if (options.EnableEventLogging && options.EnableFileLogging)
            {
                LogManager.Initialize(
                    new CompositeLogger(
                        new FileLogger(Path.Combine(Folders.Logs)),
                        new EventLogger(options.EventSourceName)));
            }
        }
    }
}
