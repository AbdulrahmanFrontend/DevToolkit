using DevToolkit.Data.Core;
using DevToolkit.Infrastructure.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    internal static class DatabaseInitializer
    {
        public static void Initialize(
        DatabaseOptions options,
        AppFolders folders)
        {
            IDatabaseProvider provider = CreateProvider(options.Provider);

            bool created = provider.EnsureCreated(options, folders);

            if (created && options.RunScripts)
            {
                DatabaseScriptRunnerFactory
                    .Create(options.Provider)
                    .Run(options);
            }

            DbManager.Initialize(options.Provider);
        }

        private static IDatabaseProvider CreateProvider(
            DbProviderFactory.DbProvider provider)
        {
            switch (provider)
            {
                case DbProviderFactory.DbProvider.SQLite:
                    return new SQLiteDatabaseProvider();

                default:
                    throw new NotSupportedException(
                        $"Provider '{provider}' is not supported.");
            }
        }
    }
}
