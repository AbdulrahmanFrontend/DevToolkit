using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using DevToolkit.Data.Parameters;

namespace DevToolkit.Data.Abstractions
{
    public interface IDbExecutor
    {
        DataTable GetDataTable(
            CommandType commandType, 
            string CommandText,
            DbParameterInfo[] Parameters = null);

        DataRow GetFirstRow(
            CommandType commandType,
            string CommandText,
            DbParameterInfo[] parameters = null);

        object GetScalar(
            CommandType commandType,
            string CommandText,
            DbParameterInfo[] Parameters = null);

        int ExecuteNonQuery(
            CommandType commandType,
            string CommandText,
            DbParameterInfo[] Parameters = null);
    }
}
