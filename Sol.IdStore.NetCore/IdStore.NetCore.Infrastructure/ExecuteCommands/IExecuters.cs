using IdStore.NetCore.Domain.Enums;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace IdStore.NetCore.Infrastructure.ExecuteCommands
{
    public interface IExecuters
    {
        void ExecuteCommand(EnumDbConnName connectionName, Action<SqlConnection> task);
        T ExecuteCommand<T>(EnumDbConnName connectionName, Func<SqlConnection, T> task);
        T ExecuteMultipleCommand<T>(EnumDbConnName connectionName, Func<SqlConnection, T> task);
        void CloseConnection();
    }
}
