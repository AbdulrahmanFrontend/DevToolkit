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

namespace DevToolkit.Data.Executors
{
    public class DbExecutor
    {
        private static SqlCommand _PrepareCommand(SqlConnection con,
            CommandType Type, string CommandText, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(CommandText, con);
            cmd.CommandType = Type;
            if (parameters != null)
            {
                foreach(var p in parameters)
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
        private static string _GetConnection()
        {
            string ConnectionString = ConfigurationManager
                .ConnectionStrings["ConnectionString"]?.ConnectionString;
            if (string.IsNullOrEmpty(ConnectionString))
            {
                return string.Empty;
            }
            return ConnectionString;
        }
        public static DataTable GetDataTable(CommandType Type, string CommandText, 
            SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_GetConnection()))
            {
                using (SqlCommand cmd = 
                    _PrepareCommand(con, Type, CommandText, parameters))
                {
                    try
                    {
                        con.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        LogManager.Current.LogError("GetDataTable Failed;", ex);
                        return new DataTable();
                    }
                }
            }
            return dt;
        }
        public static DataRow GetFirstRow(CommandType Type, string CommandText, 
            SqlParameter[] parameters = null)
        {
            DataTable dt = GetDataTable(Type, CommandText, parameters);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
        public static object GetScalar(CommandType Type, string CommandText,
            SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(_GetConnection()))
            {
                using (SqlCommand cmd = 
                    _PrepareCommand(con, Type, CommandText, parameters))
                {
                    try
                    {
                        con.Open();
                        return cmd.ExecuteScalar();
                    }
                    catch(SqlException ex)
                    {
                        LogManager.Current.LogError("GetScalar Failed;", ex);
                        return null;
                    }
                }
            }
        }
        public static int ExecuteNonQuery(CommandType Type, string CommandText, 
            SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(_GetConnection()))
            {
                using (SqlCommand cmd = 
                    _PrepareCommand(con, Type, CommandText, parameters))
                {
                    try
                    {
                        con.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex)
                    {
                        LogManager.Current.LogError("ExecuteNonQuery Failed;", ex);
                        return 0;
                    }
                }
            }
        }
    }
}
