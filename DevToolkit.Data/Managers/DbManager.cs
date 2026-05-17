using DevToolkit.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Managers
{
    public class DbManager
    {
        public static IDbExecutor Current { get; set; }
    }
}
