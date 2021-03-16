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
                    Convert.ToInt32(row["Id"].ToString()),                                                  // Requiered field
                    row["FirstName"].ToString(),                                                            // Requiered field
                    row["LastName"].ToString(),                                                             // Requiered field
                    row["Gender"].ToString(),                                                               // Requiered field
                    row["Phone"]?.ToString(),                                                               // Unrequiered field
                    row["City"]?.ToString(),                                                                // Unrequiered field
                    row["Address"]?.ToString(),                                                             // Unrequiered field
                    row["DocumentTypeId"] == DBNull.Value ? -1 : Convert.ToInt32(row["DocumentTypeId"]),    // Unrequiered field
                    row["DocumentCode"]?.ToString()                                                         // Unrequiered field
                    ));
            }

            return people;
        }

        public PersonEntity GetPersonEntityById(string query, int id)
        {
            DataTable tabletResult = ExecuteReader(query, CommandType.Text);

            return new PersonEntity(
                Convert.ToInt32(tabletResult.Columns["Id"]),
                tabletResult.Columns["FirstName"].ToString(),
                tabletResult.Columns["LastName"].ToString(),
                tabletResult.Columns["Gender"].ToString(),
                tabletResult.Columns["Phone"].ToString(),
                tabletResult.Columns["City"].ToString(),
                tabletResult.Columns["Address"].ToString(),
                Convert.ToInt32(tabletResult.Columns["DocumentTypeId"]),
                tabletResult.Columns["DocumentCode"].ToString()
                );
        }

        public PersonEntity GetEntityById(int id, string query)
        {
            throw new NotImplementedException();
        }
    }
}
