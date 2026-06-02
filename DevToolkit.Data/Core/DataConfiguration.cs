using DevToolkit.Core.Guards;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            Guard.AgainstNullOrWhiteSpace(connectionString, nameof(connectionString));
            ConnectionString = connectionString;
        }
    }
}
