using DevToolkit.Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    internal interface IDatabaseBackupProvider
    {
        Result<string> Backup(string databaseName);
    }
}
