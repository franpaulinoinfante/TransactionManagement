using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using TransactionManagement.Core.Entities.PersonAggregate;
using TransactionManagement.Core.Interfaces;

namespace TransactionManagement.Infrastructure.Repositories
{
    public class PersonRepository : MasterRepository, IPersonRepository
    {
        public int Create(PersonEntity entity, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@FirstName",entity.FirstName),
                new SQLiteParameter("@LastName",entity.LastName),
                new SQLiteParameter("@Gender",entity.Gender),
                new SQLiteParameter("@Phone",entity.Phone),
                new SQLiteParameter("@City",entity.City),
                new SQLiteParameter("@Address",entity.Address),
                new SQLiteParameter("@DocumentTypeId",entity.DocumentTypeId),
                new SQLiteParameter("@DocumentCode",entity.DocumentCode)
            };

            return ExecuteScalar(query, CommandType.Text);
        }

        public bool Remove(int id, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",id)
            };

            return ExecuteNonQuery(query, CommandType.Text);
        }

        public bool Update(PersonEntity entity, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id", entity.Id),
                new SQLiteParameter("@FirstName", entity.FirstName),
                new SQLiteParameter("@LastName", entity.LastName),
                new SQLiteParameter("@Gender", entity.Gender),
                new SQLiteParameter("@Phone", entity.Phone),
                new SQLiteParameter("@City", entity.City),
                new SQLiteParameter("@Address", entity.Address),
                new SQLiteParameter("@DocumentTypeId", entity.DocumentTypeId),
                new SQLiteParameter("@DocumentCode", entity.DocumentCode)
            };

            return ExecuteNonQuery(query, CommandType.Text);
        }

        public IEnumerable<PersonEntity> GetEntities(string query)
        {
            DataTable tabletResults = ExecuteReader(query, CommandType.Text);
            List<PersonEntity> people = new List<PersonEntity>();

            foreach (DataRow row in tabletResults.Rows)
            {
                people.Add(new PersonEntity(
                    Convert.ToInt32(row["Id"].ToString()),
                    row["FirstName"].ToString(),
                    row["LastName"].ToString(),
                    row["Gender"].ToString(),
                    row["Phone"]?.ToString(),
                    row["City"]?.ToString(),
                    row["Address"]?.ToString(),
                    row["DocumentTypeId"] == DBNull.Value ? 0 : Convert.ToInt32(row["DocumentTypeId"]),
                    row["DocumentCode"]?.ToString()
                    ));
            }

            return people;
        }

        public PersonEntity GetEntityById(int id, string query)
        {
            _parameters = new List<SQLiteParameter>{
                new SQLiteParameter("@Id",id)
            };

            DataTable tableResult = ExecuteReader(query, CommandType.Text);

            if (tableResult.Rows.Count == 0)
            {
                throw new Exception("Esta persona no esta registrada en el sistema");
            }

            return new PersonEntity(
                Convert.ToInt32(tableResult.Columns["Id"]),
                tableResult.Columns["FirstName"].ToString(),
                tableResult.Columns["LastName"].ToString(),
                tableResult.Columns["Gender"].ToString(),
                tableResult.Columns["Phone"].ToString(),
                tableResult.Columns["City"].ToString(),
                tableResult.Columns["Address"].ToString(),
                Convert.ToInt32(tableResult.Columns["DocumentTypeId"]),
                tableResult.Columns["DocumentCode"].ToString()
                );
        }
    }
}
