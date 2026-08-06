using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Startup
{
    public class StartupOptions
    {
        public string ApplicationName { get; set; }

        public string CompanyName { get; set; }

        public bool EnableFileLogging { get; set; }

        public bool EnableEventLogging { get; set; }
    }
}
