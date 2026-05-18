using DevToolkit.Logging.Abstractions;
using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Data.Abstractions;
using DevToolkit.Data.Managers;
using DevToolkit.Data.Providers;

namespace DevToolKit.Infrastructure.Configuration
{
    public class ToolkitConfiguration
    {
        public static void Initialize(
        DbProviderFactory.DbProvider provider,
        ILogger logger)
        {
            DbManager.Current = DbProviderFactory.Create(provider);

            LogManager.Current = logger;
        }
    }
}
