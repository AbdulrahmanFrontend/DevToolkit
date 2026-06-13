using DevToolkit.Core.Results;
using DevToolkit.Data.Core;
using DevToolkit.Data.Executors;
using DevToolkit.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data
{
    public static class DataQueryService
    {
        public static Result<IEnumerable<T>> Query<T>(CommandType commandType, 
            string CommandText, IEnumerable<DbParameterInfo> Parameters = null) where T : new()
        {
            List<T> ObjsList = new List<T>();

            Result<DataTable> dtResult = DbManager.Current?
                .GetDataTable(commandType, CommandText, Parameters);

            if (dtResult == null || !dtResult.IsSuccess)
                return Result<IEnumerable<T>>.Failure(dtResult?.Message);

            DataTable dt = dtResult.Data;
            foreach (DataRow dr in dt.Rows)
            {
                T Obj = DataMapper.Map<T>(dr);
                ObjsList.Add(Obj);
            }

            return Result<IEnumerable<T>>.Success(ObjsList);
        }

        public static Result<T> FirstOrDefault<T>(CommandType commandType, string CommandText,
                IEnumerable<DbParameterInfo> Parameters = null) where T : new()
        {
            Result<DataRow> drResult = DbManager.Current?
                .GetFirstRow(commandType, CommandText, Parameters);

            if (drResult != null && drResult.IsSuccess)
                return Result<T>.Success(DataMapper.Map<T>(drResult.Data));

            return Result<T>.Failure(drResult?.Message);
        }

        public static Result<T> Scalar<T>(CommandType commandType, string commandText,
            IEnumerable<DbParameterInfo> Parameters = null)
            => DbManager.Current?.GetScalar<T>(commandType, commandText, Parameters);
    }
}
