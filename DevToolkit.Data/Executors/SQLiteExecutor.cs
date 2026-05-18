using DevToolkit.Data.Abstractions;
using DevToolkit.Data.Parameters;
using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Executors
{
    public class SQLiteExecutor : IDbExecutor
    {
        private SqliteCommand _PrepareCommand(SqliteConnection con,
            CommandType Type, string CommandText, SqliteParameter[] Parameters)
        {
            SqliteCommand cmd = new SqliteCommand(CommandText, con);
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

        private SqliteParameter[] _CreateParameters(DbParameterInfo[] Parameters)
        {
            if (Parameters == null)
            {
                return new SqliteParameter[0];
            }

            return Parameters.Select(p =>
            {
                SqliteParameter param = new SqliteParameter();

                param.ParameterName = p.Name;
                param.Value = p.Value ?? DBNull.Value;
                param.DbType = p.DbType;

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
            using (SqliteConnection con = new SqliteConnection(_GetConnection()))
            {
                using (SqliteCommand cmd = _PrepareCommand(con, commandType, CommandText,
                    _CreateParameters(Parameters)))
                {
                    try
                    {
                        con.Open();
                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (SqliteException ex)
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
            using (SqliteConnection con = new SqliteConnection(_GetConnection()))
            {
                using (SqliteCommand cmd = _PrepareCommand(con, commandType, CommandText,
                    _CreateParameters(Parameters)))
                {
                    try
                    {
                        con.Open();
                        return cmd.ExecuteScalar();
                    }
                    catch (SqliteException ex)
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
            using (SqliteConnection con = new SqliteConnection(_GetConnection()))
            {
                using (SqliteCommand cmd = _PrepareCommand(con, commandType, CommandText,
                    _CreateParameters(Parameters)))
                {
                    try
                    {
                        con.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (SqliteException ex)
                    {
                        LogManager.LogError("ExecuteNonQuery Failed;", ex);
                        return 0;
                    }
                }
            }
        }
    }
}
