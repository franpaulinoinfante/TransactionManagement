using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.PersonAggregate;
using TransactionManagement.Core.Interfaces;

namespace TransactionManagement.Infrastructure.Repositories
{
    public class IncumbentRepository : MasterRepository, IIncumbentRepository
    {
        public int Create(IncumbentEntity entity, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",entity.Id),
                new SQLiteParameter("@IncumbentType",entity.IncumbentType)
            };
            return ExecuteScalar(query, CommandType.StoredProcedure);
        }

        public IEnumerable<IncumbentEntity> GetEntities(string query)
        {
            DataTable tabletResults = ExecuteReader(query, CommandType.Text);
            List<IncumbentEntity> incumbents = new List<IncumbentEntity>();

            foreach (DataRow row in tabletResults.Rows)
            {
                incumbents.Add(new IncumbentEntity(
                    int.Parse(row["Id"].ToString()),
                    row["FirstName"].ToString(),
                    row["LastName"].ToString(),
                    row["Gender"].ToString(),
                    row["Phone"].ToString(),
                    row["City"].ToString(),
                    row["Address"].ToString(),
                    row["DocumentTypeId"] == DBNull.Value ? -1 : Convert.ToInt32(row["DocumentTypeId"]),
                    row["DocumentCode"].ToString(),
                    (string)row["IncumbentType"]));
            }
            return incumbents;
        }

        public IncumbentEntity GetEntityById(int id, string query)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",id)
            };
            return ExecuteNonQuery(query, CommandType.StoredProcedure);
        }

        public bool Update(IncumbentEntity entity, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",entity.Id),
                new SQLiteParameter("@IncumebentType",entity.IncumbentType) 
            };
            return ExecuteNonQuery(query, CommandType.StoredProcedure);
        }
    }
}
