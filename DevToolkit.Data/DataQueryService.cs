using DevToolkit.Data.Mapping;
using DevToolkit.Data.Executors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Data.Builders;
using DevToolkit.Data.Managers;
using DevToolkit.Data.Abstractions;
using System.Data.Common;

namespace DevToolkit.Data
{
    public class DataQueryService
    {
        public static List<T> Query<T>(CommandType Type, string CommandText,
            DbParameter[] Parameters = null
            /*, Action<clsQueryOptions> OptionsAction = null*/) where T : new()
        {
            //var Options = new clsQueryOptions 
            //{
            //    UseCache = true, Page = 1, PageSize = 0 
            //};
            //OptionsAction?.Invoke(Options);
            
            //if(Options.Page > 0 && Options.PageSize > 0)
            //{
            //    List<SqlParameter> ParamsList =
            //        Parameters?.ToList() ?? new List<SqlParameter>();
            //    ParamsList.Add(new SqlParameter("@Page", SqlDbType.Int) 
            //    { 
            //        Value = Options.Page
            //    });
            //    ParamsList.Add(new SqlParameter("@PageSize", SqlDbType.Int)
            //    { 
            //        Value = Options.PageSize
            //    });
            //    Parameters = ParamsList.ToArray();
            //}
            //string ParamsKey = Parameters == null ? "NULL" : string.Join("_",
            //    Parameters.Select(p => p.ParameterName + "_" + p.Value));
            //string Key = $"{CommandText}_{typeof(T).Name}_{ParamsKey}";

            List<T> ObjsList;
            //if (Options.UseCache &&
            //    clsCacheManager.Cache.TryGetValue(Key, out var Json))
            //{
            //    var Result = JsonSerializer.Deserialize<List<T>>(Json);
            //    return Result ?? new List<T>();
            //}
            //else
            //{
                DataTable dt = 
                    DbManager.Current?.GetDataTable(Type, CommandText, Parameters);
                ObjsList = new List<T>();
                foreach (DataRow dr in dt.Rows)
                {
                    T Obj = DataMapper.Map<T>(dr);
                    ObjsList.Add(Obj);
                }

                //if (Options.UseCache)
                //{
                //    clsCacheManager.Cache[Key] = 
                //        JsonSerializer.Serialize(ObjsList);
                //    clsCacheManager.SaveCache();
                //}
            //}

            return ObjsList;
        }

        public static T FirstOrDefault<T>(CommandType Type, string CommandText,
                DbParameter[] Parameters = null) where T : new()
        {
            DataRow dr = DbManager.Current?.GetFirstRow(Type, CommandText, Parameters);
            if (dr != null)
            {
                return DataMapper.Map<T>(dr);
            }
            return default(T);
        }
    }
}
