using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Parameters
{
    public class DbParameterInfo
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public DbType dbType { get; set; }
    }
}
