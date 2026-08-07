using System;
using DevToolkit.Data.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    internal class DatabaseScriptRunnerFactory
    {
        public static IDatabaseScriptRunner Create(
        DbProviderFactory.DbProvider provider)
        {
            switch (provider)
            {
                case DbProviderFactory.DbProvider.SQLite:
                    return new SQLiteDatabaseScriptRunner();

                default:
                    throw new NotSupportedException(
                        $"Provider not supported: {provider}");
            }
        }
    }
}
