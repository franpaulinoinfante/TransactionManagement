using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace TransactionManagement.Infrastructure.Repositories
{
    public abstract class MasterRepository : Data.ConnectionToSQLite, IDisposable
    {
        protected List<SQLiteParameter> _parameters;

        protected bool ExecuteNonQuery(string query, CommandType commandType)
        {
            using (SQLiteCommand sqlCommand = new SQLiteCommand())
            {
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = commandType;

                foreach (SQLiteParameter parameter in _parameters)
                {
                    sqlCommand.Parameters.Add(parameter);
                }

                using (SQLiteConnection connection = GetSqlConnection)
                {
                    connection.Open();
                    sqlCommand.Connection = connection;

                    int rowsaffected = sqlCommand.ExecuteNonQuery();

                    Dispose();

                    if (rowsaffected == -1)
                    {
                        return false;
                    }
                    return true;
                }
            }
        }

        protected int ExecuteScalar(string query, CommandType commandType)
        {
            using (SQLiteCommand sqlCommand = new SQLiteCommand())
            {
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = commandType;

                foreach (SQLiteParameter parameter in _parameters)
                {
                    sqlCommand.Parameters.Add(parameter);
                }

                using (SQLiteConnection connection = GetSqlConnection)
                {
                    connection.Open();
                    sqlCommand.Connection = connection;

                    int newId = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    Dispose();

                    return newId;
                }
            }
        }

        protected DataTable ExecuteReader(string query, CommandType commandType)
        {
            using (SQLiteCommand sqlCommand = new SQLiteCommand())
            {
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = commandType;

                if (_parameters != null)
                {
                    foreach (SQLiteParameter parameter in _parameters)
                    {
                        sqlCommand.Parameters.Add(parameter);
                    }
                }

                using (SQLiteConnection connection = GetSqlConnection)
                {
                    connection.Open();
                    sqlCommand.Connection = connection;

                    SQLiteDataReader sqlReader = sqlCommand.ExecuteReader();
                    using (DataTable tabletResult = new DataTable())
                    {
                        tabletResult.Load(sqlReader);

                        Dispose();

                        return tabletResult;
                    }
                }
            }
        }

        public void Dispose()
        {
            GetSqlConnection.Close();

            if (_parameters != null)
            {
                _parameters.Clear();
            }
        }
    }
}
