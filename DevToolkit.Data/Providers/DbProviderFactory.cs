using DevToolkit.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Providers
{
    public class DbProviderFactory
    {
        public enum DbProvider
        {
            SqlServer,
            SQLite
        }

        public static IDbExecutor Create(DbProvider Provider)
        {
            switch (Provider)
            {
                case DbProvider.SqlServer:
                    return new Executors.SqlServerExecutor();
                case DbProvider.SQLite:
                    return new Executors.SQLiteExecutor();
                default:
                    throw new NotSupportedException($"The provider {Provider} is not supported.");
            }
        }
    }
}
