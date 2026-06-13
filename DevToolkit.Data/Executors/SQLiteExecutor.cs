using DevToolkit.Core.Guards;
using DevToolkit.Core.Results;
using DevToolkit.Data.Core;
using DevToolkit.Logging.Managers;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Executors
{
    public class SQLiteExecutor : IDbExecutor
    {
        private SQLiteCommand _PrepareCommand(SQLiteConnection con,
            CommandType commandType, string CommandText, IEnumerable<SQLiteParameter> Parameters)
        {
            SQLiteCommand cmd = new SQLiteCommand(CommandText, con);
            cmd.CommandType = commandType;

            if (Guard.HasItems(Parameters))
                foreach (var p in Parameters)
                {
                    if (p.Value == null)
                        p.Value = DBNull.Value;

                    cmd.Parameters.Add(p);
                }

            return cmd;
        }

        private IEnumerable<SQLiteParameter> _CreateParameters(
            IEnumerable<DbParameterInfo> Parameters)
        {
            if (!Guard.HasItems(Parameters))
                return new SQLiteParameter[0];

            return Parameters.Select(p =>
            {
                SQLiteParameter param = new SQLiteParameter();

                param.ParameterName = p.Name;
                param.Value = p.Value ?? DBNull.Value;
                param.DbType = p.DbType;
                param.Size = p.Size;
                param.Direction = p.Direction;

                return param;

            }).ToArray();
        }

        public Result<DataTable> GetDataTable(CommandType commandType, string CommandText,
            IEnumerable<DbParameterInfo> Parameters = null)
        {
            try
            {
                using (SQLiteConnection con = 
                    new SQLiteConnection(DataConfiguration.ConnectionString))
                    using (SQLiteCommand cmd = _PrepareCommand(con, commandType, CommandText,
                        _CreateParameters(Parameters)))
                    {
                        DataTable dt = new DataTable();

                        con.Open();

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                            if (reader.HasRows)
                                dt.Load(reader);

                        return Result<DataTable>.Success(dt);
                    }
            }
            catch (Exception ex)
            {
                LogManager.LogError($"GetDataTable Failed. Command: {CommandText}", ex);
                return Result<DataTable>.Failure("Failed to retrieve data table.");
            }
        }

        public Result<DataRow> GetFirstRow(CommandType commandType, string CommandText,
            IEnumerable<DbParameterInfo> Parameters = null)
        {
            Result<DataTable> dtResult = GetDataTable(commandType, CommandText, Parameters);
            if (!dtResult.IsSuccess)
                return Result<DataRow>.Failure("Failed to retrieve data row.");

            DataTable dt = dtResult.Data;
            return dt.Rows.Count > 0 ? Result<DataRow>.Success(dt.Rows[0]) : 
                Result<DataRow>.Success(default(DataRow) ,"No rows found.");
        }

        public Result<T> GetScalar<T>(CommandType commandType, string CommandText,
            IEnumerable<DbParameterInfo> Parameters = null)
        {
            try
            {
                using (SQLiteConnection con = 
                    new SQLiteConnection(DataConfiguration.ConnectionString))
                    using (SQLiteCommand cmd = _PrepareCommand(con, commandType, CommandText,
                        _CreateParameters(Parameters)))
                    {
                        con.Open();

                        object result = cmd.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                            return Result<T>.Success(default
                                ,"Failed to retrieve scalar value.");

                        return Result<T>.Success((T)Convert.ChangeType(result, typeof(T)));
                    }
            }
            catch (Exception ex)
            {
                LogManager.LogError($"GetScalar Failed. Command: {CommandText}", ex);
                return Result<T>.Failure("Failed to retrieve scalar value.");
            }
        }

        public Result<int> ExecuteNonQuery(CommandType commandType, string CommandText,
            IEnumerable<DbParameterInfo> Parameters = null)
        {
            try
            {
                using (SQLiteConnection con = 
                    new SQLiteConnection(DataConfiguration.ConnectionString))
                    using (SQLiteCommand cmd = _PrepareCommand(con, commandType, CommandText,
                        _CreateParameters(Parameters)))
                    {
                        con.Open();
                        return Result<int>.Success(cmd.ExecuteNonQuery());
                    }
            }
            catch (Exception ex)
            {
                LogManager.LogError($"ExecuteNonQuery Failed. Command: {CommandText}", ex);
                return Result<int>.Failure("Failed to execute non-query.");
            }
        }

        public Result<DataSet> GetDataSet(CommandType commandType, string CommandText, 
            IEnumerable<DbParameterInfo> Parameters = null)
        {
            try
            {
                using(SQLiteConnection con = 
                    new SQLiteConnection(DataConfiguration.ConnectionString))
                    using (SQLiteCommand cmd = _PrepareCommand(con, commandType, CommandText,
                        _CreateParameters(Parameters)))
                    {
                        con.Open();

                        DataSet ds = new DataSet();

                        using(SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            ds.Tables.Add(dt);
                        }

                        return Result<DataSet>.Success(ds);
                    }
            }
            catch(Exception ex)
            {
                LogManager.LogError($"GetDataSet Failed. Command: {CommandText}", ex);
                return Result<DataSet>.Failure("Failed to retrieve data set.");
            }
        }

        public Result ExecuteTransaction(Action<IDbConnection, IDbTransaction> action)
        {
            try
            {
                using (SQLiteConnection con = 
                    new SQLiteConnection(DataConfiguration.ConnectionString))
                {
                    con.Open();

                    using (SQLiteTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            action(con, transaction);
                            transaction.Commit();

                        }
                        catch (Exception ex)
                        {
                            LogManager.LogError("Transaction Failed. Rolling back.", ex);
                            transaction?.Rollback();
                            return Result.Failure("Failed to execute transaction.");
                        }
                    }
                }

                return Result.Success();
            }
            catch (Exception ex)
            {
                LogManager.LogError("ExecuteTransaction Failed.", ex);
                return Result.Failure("Failed to execute transaction.");
            }
        }
    }
}
