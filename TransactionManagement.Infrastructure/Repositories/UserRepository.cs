using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using TransactionManagement.Core.Entities;
using TransactionManagement.Core.Interfaces;

namespace TransactionManagement.Infrastructure.Repositories
{
    public class UserRepository : MasterRepository, IUserRepository
    {
        public IEnumerable<UserEntity> GetEntities(string query)
        {
            var tableResult = ExecuteReader(query, CommandType.Text);
            var userEntities = new List<UserEntity>();

            foreach (DataRow row in tableResult.Rows)
            {
                userEntities.Add(new UserEntity(
                    Convert.ToInt32(row["Id"].ToString()),
                    row["UserName"].ToString(),
                    row["Password"].ToString(),
                    row["FirstName"].ToString(),
                    row["LastName"].ToString(),
                    row["Gender"].ToString(),
                    Convert.ToInt32(row["DocumentTypeId"].ToString()),
                    row["DocumentCode"].ToString(),
                    row["Phone"].ToString(),
                    row["City"].ToString(),
                    row["Address"].ToString()));
            }

            return userEntities;
        }

        public UserEntity GetEntityById(int id, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",id)
            };

            var tableResult = ExecuteReader(query, CommandType.Text);

            return new UserEntity(
                Convert.ToInt32(tableResult.Columns["Id"]),
                tableResult.Columns["UserName"].ToString(),
                tableResult.Columns["Password"].ToString(),
                tableResult.Columns["FistName"].ToString(),
                tableResult.Columns["LastName"].ToString(),
                tableResult.Columns["Gender"].ToString(),
                Convert.ToInt32(tableResult.Columns["DocumentTypeId"].ToString()),
                tableResult.Columns["DocumentCode"].ToString(),
                tableResult.Columns["Phone"].ToString(),
                tableResult.Columns["City"].ToString(),
                tableResult.Columns["Address"].ToString());
        }

        public UserEntity GetUserEntityByUserName(string query, string userName)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@UserName",userName)
            };

            var tableResult = ExecuteReader(query, CommandType.Text);

            return new UserEntity(
                Convert.ToInt32(tableResult.Columns["Id"]),
                tableResult.Columns["UserName"].ToString(),
                tableResult.Columns["Password"].ToString(),
                tableResult.Columns["FistName"].ToString(),
                tableResult.Columns["LastName"].ToString(),
                tableResult.Columns["Gender"].ToString(),
                Convert.ToInt32(tableResult.Columns["DocumentTypeId"].ToString()),
                tableResult.Columns["DocumentCode"].ToString(),
                tableResult.Columns["Phone"].ToString(),
                tableResult.Columns["City"].ToString(),
                tableResult.Columns["Address"].ToString());
        }

        public int Create(UserEntity entity, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@UserName",entity.UserName),
                new SQLiteParameter("@Password",entity.Password),
                new SQLiteParameter("@FirstName",entity.FirstName),
                new SQLiteParameter("@LastName",entity.LastName),
                new SQLiteParameter("@Gender",entity.Gender),
                new SQLiteParameter("@City",entity.City),
                new SQLiteParameter("@Address",entity.Address),
                new SQLiteParameter("@DocumentTypeId",entity.DocumentTypeId),
                new SQLiteParameter("@DocumentCode",entity.DocumentCode)
            };

            return ExecuteScalar(query, CommandType.StoredProcedure);
        }

        public bool Remove(int id, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",id)
            };

            return ExecuteNonQuery(query, CommandType.Text);
        }

        public bool Update(UserEntity entity, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",entity.Id),
                new SQLiteParameter("@UserName",entity.UserName),
                new SQLiteParameter("@Password",entity.Password),
                new SQLiteParameter("@FirstName",entity.FirstName),
                new SQLiteParameter("@LastName",entity.LastName),
                new SQLiteParameter("@Gender",entity.Gender),
                new SQLiteParameter("@City",entity.City),
                new SQLiteParameter("@Address",entity.Address),
                new SQLiteParameter("@DocumentTypeId",entity.DocumentTypeId),
                new SQLiteParameter("@DocumentCode",entity.DocumentCode)
            };

            return ExecuteNonQuery(query, CommandType.Text);
        }
    }
}
