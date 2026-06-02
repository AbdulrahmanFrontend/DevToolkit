using DevToolkit.Logging.Abstractions;
using DevToolkit.Logging.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Logging.Configuration
{
    public class LoggerConfiguration
    {
        public static ILogger CreateDefault() 
            => new CompositeLogger(
                new ILogger[]
                {
                    new FileLogger(),
                    new EventLogger()
                });
    }
}
