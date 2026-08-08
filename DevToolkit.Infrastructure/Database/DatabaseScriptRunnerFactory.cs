using DevToolkit.Data.Core;
using DevToolkit.Infrastructure.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    internal class DatabaseScriptRunnerFactory
    {
        public static IDatabaseScriptRunner Create()
        {
            switch (StartupManager.DatabaseOptions.Provider)
            {
                case DbProviderFactory.DbProvider.SQLite:
                    return new SQLiteDatabaseScriptRunner();

                default:
                    throw new NotSupportedException(
                        $"Provider not supported: " +
                        $"{StartupManager.DatabaseOptions.Provider}");
            }
        }
    }
}
