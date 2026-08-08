using DevToolkit.Core.Common;
using DevToolkit.Core.Guards;
using DevToolkit.Core.Results;
using DevToolkit.Data.Executors;
using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Core
{
    public static class DataConfiguration
    {
        public static string ConnectionString { get; private set; }

        public static void Configure(string connectionString)
        {
            Guard.AgainstNullOrWhiteSpace(
                connectionString, 
                nameof(connectionString));

            ConnectionString = connectionString;
        }
    }
}
