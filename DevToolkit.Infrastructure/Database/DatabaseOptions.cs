using System;
using System.Collections.Generic;
//using DevToolkit.;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    public class DatabaseOptions
    {
        //public DbProviderFactory Provider { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseFileName { get; set; }

        public bool CreateIfNotExists { get; set; } = true;

        public bool RunScripts { get; set; } = true;
    }
}
