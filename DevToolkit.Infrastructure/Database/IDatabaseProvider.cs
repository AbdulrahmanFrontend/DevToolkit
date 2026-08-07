using DevToolkit.Infrastructure.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Database
{
    internal interface IDatabaseProvider
    {
        void EnsureCreated(DatabaseOptions options, AppFolders folders);
    }
}
