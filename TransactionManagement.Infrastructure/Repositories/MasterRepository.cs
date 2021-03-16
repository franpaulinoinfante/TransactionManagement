using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    
                    var number = sqlCommand.ExecuteNonQuery();

                    Dispose();

                    if (number > 0)
                    {
                        return true;
                    }
                    return false;
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

                    if (newId > 0)
                    {
                        return newId;
                    }
                    throw new SQLiteException();
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
                    foreach (var parameter in _parameters)
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
