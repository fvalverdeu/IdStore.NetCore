using IdStore.NetCore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace IdStore.NetCore.Infrastructure.ExecuteCommands
{
    public class Executers : IExecuters
    {
        private readonly IDictionary<EnumDbConnName, string> _connectionDict;
        private SqlConnection conn;

        public Executers(IDictionary<EnumDbConnName, string> connectionDict)
        {
            _connectionDict = connectionDict;
        }
        public void ExecuteCommand(EnumDbConnName connectionName, Action<SqlConnection> task)
        {
            SqlConnection conn = CreateConnection(connectionName);
            conn.Open();
            task(conn);
        }
        public T ExecuteCommand<T>(EnumDbConnName connectionName, Func<SqlConnection, T> task)
        {
            conn = CreateConnection(connectionName);
            conn.Open();
            return task(conn);
        }
        public T ExecuteMultipleCommand<T>(EnumDbConnName connectionName, Func<SqlConnection, T> task)
        {
            conn = CreateConnection(connectionName);
            conn.Open();
            return task(conn);
        }
        private SqlConnection CreateConnection(EnumDbConnName connectionName)
        {
            if (_connectionDict.TryGetValue(connectionName, out string connectionString))
            {
                return new SqlConnection(connectionString);
            }
            throw new ArgumentNullException();
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
