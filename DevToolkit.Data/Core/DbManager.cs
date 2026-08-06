using DevToolkit.Core.Common;
using DevToolkit.Core.Results;
using DevToolkit.Data.Core;
using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Core
{
    public static class DbManager
    {
        public static IDbExecutor Current { get; private set; }

        public static void Initialize(DevToolkit.Data.Core.DbProviderFactory.DbProvider provider)
        {
            if(Current != null)
                throw new InvalidOperationException("DbManager is already initialized.");

            Current = DevToolkit.Data.Core.DbProviderFactory.Create(provider);
        }
    }
}
