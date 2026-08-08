using DevToolkit.Data.Core;
using DevToolkit.Infrastructure.FileSystem;
using DevToolkit.Infrastructure.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    internal static class DatabaseInitializer
    {
        public static void Initialize()
        {
            IDatabaseProvider provider = CreateProvider();

            bool created = provider.EnsureCreated();

            if (created && StartupManager.DatabaseOptions.RunScripts)
            {
                DatabaseScriptRunnerFactory
                    .Create()
                    .Run();
            }

            DbManager.Initialize(StartupManager.DatabaseOptions.Provider);
        }

        private static IDatabaseProvider CreateProvider()
        {
            switch (StartupManager.DatabaseOptions.Provider)
            {
                case DbProviderFactory.DbProvider.SQLite:
                    return new SQLiteDatabaseProvider();

                default:
                    throw new NotSupportedException(
                        $"Provider '{StartupManager.DatabaseOptions.Provider}' " +
                        $"is not supported.");
            }
        }
    }
}
