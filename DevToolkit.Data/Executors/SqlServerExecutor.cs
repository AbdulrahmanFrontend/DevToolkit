using DevToolkit.Data.Abstractions;
using DevToolkit.Data.Parameters;
using DevToolkit.Logging.Managers;
using DevToolkit.Logging.Providers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Executors
{
    public class SqlServerExecutor : IDbExecutor
    {
        private SqlCommand _PrepareCommand(SqlConnection con,
            CommandType Type, string CommandText, SqlParameter[] Parameters)
        {
            SqlCommand cmd = new SqlCommand(CommandText, con);
            cmd.CommandType = Type;
            if (Parameters != null)
            {
                foreach (var p in Parameters)
                {
                    if (p.Value == null)
                    {
                        p.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(p);
                }
            }
            return cmd;
        }

        private SqlParameter[] _CreateParameters(DbParameterInfo[] Parameters)
        {
            if (Parameters == null)
            {
                return new SqlParameter[0];
            }

            return Parameters.Select(p =>
            {
                SqlParameter param = new SqlParameter();

                param.ParameterName = p.Name;
                param.Value = p.Value ?? DBNull.Value;
                param.DbType = p.DbType;
                param.Size = p.Size;
                param.Direction = p.Direction;

                return param;

            }).ToArray();
        }

        private string _GetConnection()
        {
            string ConnectionString = ConfigurationManager
                .ConnectionStrings["ConnectionString"]?.ConnectionString;
            if (string.IsNullOrEmpty(ConnectionString))
            {
                return string.Empty;
            }
            return ConnectionString;
        }

        public DataTable GetDataTable(CommandType commandType, string CommandText,
            DbParameterInfo[] Parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_GetConnection()))
            {
                using (SqlCommand cmd = _PrepareCommand(con, commandType, CommandText,
                    _CreateParameters(Parameters)))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        LogManager.LogError("GetDataTable Failed;", ex);
                        return new DataTable();
                    }
                }
            }
            return dt;
        }

        public DataRow GetFirstRow(CommandType commandType, string CommandText,
            DbParameterInfo[] Parameters = null)
        {
            DataTable dt = GetDataTable(commandType, CommandText, Parameters);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public object GetScalar(CommandType commandType, string CommandText,
            DbParameterInfo[] Parameters = null)
        {
            using (SqlConnection con = new SqlConnection(_GetConnection()))
            {
                using (SqlCommand cmd = _PrepareCommand(con, commandType, CommandText, 
                    _CreateParameters(Parameters)))
                {
                    try
                    {
                        con.Open();
                        return cmd.ExecuteScalar();
                    }
                    catch(SqlException ex)
                    {
                        LogManager.LogError("GetScalar Failed;", ex);
                        return null;
                    }
                }
            }
        }

        public int ExecuteNonQuery(CommandType commandType, string CommandText,
            DbParameterInfo[] Parameters = null)
        {
            using (SqlConnection con = new SqlConnection(_GetConnection()))
            {
                using (SqlCommand cmd = _PrepareCommand(con, commandType, CommandText,
                    _CreateParameters(Parameters)))
                {
                    try
                    {
                        con.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex)
                    {
                        LogManager.LogError("ExecuteNonQuery Failed;", ex);
                        return 0;
                    }
                }
            }
        }
    }
}
