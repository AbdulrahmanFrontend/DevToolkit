using DevToolkit.Core.Common;
using DevToolkit.Core.Results;
using DevToolkit.Data.Core;
using DevToolkit.Data.Executors;
using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Core
{
    public static class DbProviderFactory
    {
        public enum DbProvider
        {
            SqlServer,
            SQLite
        }

        internal static IDbExecutor Create(DbProvider Provider)
        {
            switch (Provider)
            {
                case DbProvider.SqlServer:
                    return new SqlServerExecutor();
                case DbProvider.SQLite:
                    return new SQLiteExecutor();
                default:
                    throw new NotSupportedException($"The provider {Provider} is not supported.");
            }
        }
    }
}
