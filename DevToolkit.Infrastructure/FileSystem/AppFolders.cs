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

        public string Prints { get; }

        internal AppFolders(
            string root,
            string data,
            string logs,
            string backups,
            string settings,
            string prints)
        {
            Root = root;

            Data = data;

            Logs = logs;

            Backups = backups;

            Settings = settings;

            Prints = prints;
        }
    }
}
