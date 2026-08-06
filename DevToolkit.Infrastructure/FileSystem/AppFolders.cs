using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.FileSystem
{
    public class AppFolders
    {
        public string Root { get; }

        public string Data { get; }

        public string Logs { get; }

        public string Backups { get; }

        public string Settings { get; }

        internal AppFolders(
            string root,
            string data,
            string logs,
            string backups,
            string settings)
        {
            Root = root;

            Data = data;

            Logs = logs;

            Backups = backups;

            Settings = settings;
        }
    }
}
