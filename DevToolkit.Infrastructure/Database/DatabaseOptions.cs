using DevToolkit.Data.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    public class DatabaseOptions
    {
        public DbProviderFactory.DbProvider Provider { get; set; }

        public string DatabaseName { get; set; }

        public string DatabasePath { get; internal set; }

        internal string DatabaseScriptPath { get; set; } =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Database",
                "Scripts",
                "InitialDatabase.sql");

        public bool CreateIfNotExists { get; set; } = true;

        public bool RunScripts { get; set; } = true;
    }
}
