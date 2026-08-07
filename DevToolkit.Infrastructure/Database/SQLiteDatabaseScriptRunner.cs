using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    internal class SQLiteDatabaseScriptRunner : IDatabaseScriptRunner
    {
        public void Run(DatabaseOptions options)
        {
            if (!File.Exists(options.DatabaseScriptPath))
                throw new FileNotFoundException(
                    "Database script file not found!",
                    options.DatabaseScriptPath);

            string script = File.ReadAllText(options.DatabaseScriptPath);

            if (string.IsNullOrWhiteSpace(script))
                throw new InvalidOperationException(
                    "Database script file is empty!",
                    new FileLoadException(
                        "Database script file is empty!",
                        options.DatabaseScriptPath));
        }
    }
}
