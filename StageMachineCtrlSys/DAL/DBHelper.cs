using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Common;
using System.Data;

namespace StageMachineCtrlSys.DAL
{
    class DBHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["StageMachineCtrlSys.Properties.Settings.DB_SMCSConnectionStringFromSQL2008"].ConnectionString.ToString();
        private static readonly string providerName = "System.Data.SqlClient";       
        private static DbConnection GetConnection()   //获取连接数据库的 connection 对象
        {
            DbProviderFactory _factory = DbProviderFactories.GetFactory(providerName);
            DbConnection connection = _factory.CreateConnection();
            connection.ConnectionString = connectionString;
            return connection;
        }
        private static DbCommand GetCommand(string commandText, CommandType commandType, DbConnection connection)// 获取命令参数 command 对象
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            command.CommandType = commandType;
            return command;
        }    
        private static DbCommand GetCommand(string commandText, DbConnection connection)// GetCommand 方法重载
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            command.CommandType = CommandType.Text;
            return command;
        }    
        private static DbParameter GetParameter(string paramName, object paramValue, DbCommand command)// GetParameter 用于为命令设置参数
        {
            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = paramName;
            parameter.Value = paramValue;
            return parameter;
        }      
        public static int ExecuteNonQueryProc(string sqlCommand)  // 执行无参的存储过程
        {
            int result = 0;
            using (DbConnection connection = GetConnection())
            {
                DbCommand command = GetCommand(sqlCommand, CommandType.StoredProcedure, connection);
                connection.Open();
                result = command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            return result;
        }       
        public static int ExecuteNonQueryProc(string sqlCommand, Dictionary<string, object> parameters)// 执行无返回值有参数的存储过程
        {
            int result = 0;
            using (DbConnection connection = GetConnection())
            {
                DbCommand command = GetCommand(sqlCommand, CommandType.StoredProcedure, connection);
                foreach (KeyValuePair<string, object> p in parameters)
                {
                    command.Parameters.Add(GetParameter(p.Key, p.Value, command));
                }
                connection.Open();
                result = command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            return result;
        }
        public static int ExecuteNonQuery(string sqlCommand)   // 执行无返回值的sql语句
        {
            int result = 0;
            using (DbConnection connection = GetConnection())
            {
                DbCommand command = GetCommand(sqlCommand, CommandType.Text, connection);
                connection.Open();
                result = command.ExecuteNonQuery();
                command.Parameters.Clear();
                return result;
            }
        }    
        public static int ExecuteNonQuery(string sqlCommand, Dictionary<string, object> para)     // 执行有参数的sql语句
        {
            int result = 0;
            using (DbConnection connection = GetConnection())
            {
                DbCommand command = GetCommand(sqlCommand, CommandType.Text, connection);
                foreach (KeyValuePair<string, object> p in para)
                {
                    command.Parameters.Add(GetParameter(p.Key, p.Value, command));
                }
                connection.Open();
                result = command.ExecuteNonQuery();
                command.Parameters.Clear();
                return result;
            }
        }    
        public static object ExecuteScalarProc(string cmdText)  // 执行有返回值无参数的存储过程
        {
            using (DbConnection connection = GetConnection())
            {
                DbCommand command = GetCommand(cmdText, CommandType.StoredProcedure, connection);
                connection.Open();
                object val = command.ExecuteScalar();
                command.Parameters.Clear();
                return val;
            }
        }  
        public static object ExecuteScalarProc(string cmdText, Dictionary<string, object> para)  // 执行有返回值的有参数的存储过程
        {
            using (DbConnection connection = GetConnection())
            {
                DbCommand command = GetCommand(cmdText, CommandType.StoredProcedure, connection);
                foreach (KeyValuePair<string, object> p in para)
                {
                    command.Parameters.Add(GetParameter(p.Key, p.Value, command));
                }
                connection.Open();
                object val = command.ExecuteScalar();
                command.Parameters.Clear();
                return val;
            }
        }     
        public static object ExecuteScalar(string cmdText)  // 执行有返回值的sql语句
        {
            using (DbConnection connection = GetConnection())
            {
                DbCommand command = GetCommand(cmdText, CommandType.Text, connection);
                connection.Open();
                object val = command.ExecuteScalar();
                command.Parameters.Clear();
                return val;
            }
        }      
        public static object ExecuteScalar(string cmdText, Dictionary<string, object> para) // 执行有返回值有参数的sql语句
        {
            using (DbConnection connection = GetConnection())
            {
                DbCommand command = GetCommand(cmdText, CommandType.Text, connection);
                foreach (KeyValuePair<string, object> p in para)
                {
                    command.Parameters.Add(GetParameter(p.Key, p.Value, command));
                }
                connection.Open();
                object val = command.ExecuteScalar();
                command.Parameters.Clear();
                return val;
            }
        }      
        public static DbDataReader GetReaderProc(string sqlCommand)      // 执行无参数的存储过程,返回DbDataReader对象
        {
            try
            {
                DbConnection connection = GetConnection();
                DbCommand command = GetCommand(sqlCommand, CommandType.StoredProcedure, connection);
                connection.Open();
                DbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                Console.Write("" + ex.Message);
                return null;
            }
        }       
        public static DbDataReader GetReaderProc(string sqlCommand, Dictionary<string, object> parameters)// 执行有参数的存储过程,返回DbDataReader对象
        {
            try
            {
                DbConnection connection = GetConnection();
                DbCommand command = GetCommand(sqlCommand, CommandType.StoredProcedure, connection);
                foreach (KeyValuePair<string, object> p in parameters)
                {
                    command.Parameters.Add(GetParameter(p.Key, p.Value, command));
                }
                connection.Open();
                DbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                command.Parameters.Clear();
                return reader;
            }
            catch
            {
                return null;
            }
        }
        public static DbDataReader GetReader(string sqlCommand)  // 执行无参数的sql语句,返回DbDataReader对象
        {
            try
            {
                DbConnection connection = GetConnection();
                DbCommand command = GetCommand(sqlCommand, CommandType.Text, connection);
                connection.Open();
                DbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                command.Parameters.Clear();
                return reader;
            }
            catch (Exception ex)
            {
                Console.Write("" + ex.Message);
                return null;
            }
        }
        public static DbDataReader GetReader(string sqlCommand, Dictionary<string, object> parameters) // 执行有参数的sql语句,返回DbDataReader对象
        {
            try
            {
                DbConnection connection = GetConnection();
                DbCommand command = GetCommand(sqlCommand, CommandType.Text, connection);
                foreach (KeyValuePair<string, object> p in parameters)
                {
                    command.Parameters.Add(GetParameter(p.Key, p.Value, command));
                }
                connection.Open();
                DbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                command.Parameters.Clear();
                return reader;
            }
            catch (Exception ex)
            {
                Console.Write("" + ex.Message);
                return null;
            }
        } 
        public static DataTable GetDataSet(string safeSql)    // 返回DataTable对象
        {
            /*DbProviderFactory _factory = DbProviderFactories.GetFactory(providerName);
            DbConnection connection = GetConnection();
            connection.Open();
            DbDataAdapter da = _factory.CreateDataAdapter();
            da.SelectCommand = connection.CreateCommand();
            da.SelectCommand.CommandText = safeSql;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;*/
            using (DbConnection connection = GetConnection())
            {
                DbProviderFactory _factory = DbProviderFactories.GetFactory(providerName);
                DbCommand command = GetCommand(safeSql, CommandType.Text, connection);
                connection.Open();
                DbDataAdapter da = _factory.CreateDataAdapter();
                da.SelectCommand = command;
                DataTable datatable = new DataTable();
                da.Fill(datatable);
                return datatable;
            }
        }
    }
}
