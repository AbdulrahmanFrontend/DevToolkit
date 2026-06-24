using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using DevToolkit.Core.Results;

namespace DevToolkit.Data.Core
{
    public interface IDbExecutor
    {
        Result<DataTable> GetDataTable(
            CommandType commandType, 
            string CommandText,
            IEnumerable<DbParameterInfo> Parameters = null);

        Result<DataRow> GetFirstRow(
            CommandType commandType,
            string CommandText,
            IEnumerable<DbParameterInfo> parameters = null);

        Result<T> GetScalar<T>(
            CommandType commandType,
            string CommandText,
            IEnumerable<DbParameterInfo> Parameters = null);

        Result<T> GetScalar<T>(
            IDbConnection con,
            IDbTransaction trans,
            CommandType commandType,
            string CommandText,
            IEnumerable<DbParameterInfo> Parameters = null);

        Result<int> ExecuteNonQuery(
            CommandType commandType,
            string CommandText,
            IEnumerable<DbParameterInfo> Parameters = null);

        Result<int> ExecuteNonQuery(
            IDbConnection con,
            IDbTransaction trans,
            CommandType commandType,
            string commandText,
            IEnumerable<DbParameterInfo> parameters = null);

        Result<DataSet> GetDataSet(
            CommandType commandType,
            string CommandText,
            IEnumerable<DbParameterInfo> Parameters = null);

        Result ExecuteTransaction(
            Action<IDbConnection, IDbTransaction> action);
    }
}
