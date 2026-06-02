using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Core
{
    public class DbParameterInfo
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public DbType DbType { get; set; }
        public int Size { get; set; }
        public ParameterDirection Direction { get; set; } = ParameterDirection.Input;
        public string TypeName { get; set; }
    }
}
