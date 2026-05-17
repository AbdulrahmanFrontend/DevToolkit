using DevToolkit.Data.Abstractions;
using DevToolkit.Data.Builders;
using DevToolkit.Logging.Managers;
using DevToolkit.Logging.Providers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DevToolkit.Data.Executors
{
    public class SqlServerExecutor : IDbExecutor
    {
        private SqlCommand _PrepareCommand(SqlConnection con,
            CommandType Type, string CommandText, DbParameter[] Parameters)
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
            DbParameter[] Parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_GetConnection()))
            {
                using (SqlCommand cmd =
                    _PrepareCommand(con, commandType, CommandText, Parameters))
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
            DbParameter[] parameters = null)
        {
            DataTable dt = GetDataTable(commandType, CommandText, parameters);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public object GetScalar(CommandType commandType, string CommandText,
            DbParameter[] Parameters = null)
        {
            using (SqlConnection con = new SqlConnection(_GetConnection()))
            {
                using (SqlCommand cmd = 
                    _PrepareCommand(con, commandType, CommandText, Parameters))
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
            DbParameter[] Parameters = null)
        {
            using (SqlConnection con = new SqlConnection(_GetConnection()))
            {
                using (SqlCommand cmd = 
                    _PrepareCommand(con, commandType, CommandText, Parameters))
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
