using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Infrastructure.Data
{
    public abstract class ConnectionToSQLite
    {
        private readonly string _connectionString;

        public ConnectionToSQLite()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        protected SQLiteConnection GetSqlConnection => new SQLiteConnection(_connectionString);
    }
}
