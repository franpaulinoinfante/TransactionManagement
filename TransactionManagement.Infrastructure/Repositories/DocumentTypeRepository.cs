using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using TransactionManagement.Core.Entities;
using TransactionManagement.Core.Interfaces;

namespace TransactionManagement.Infrastructure.Repositories
{
    public class DocumentTypeRepository : MasterRepository, IDocumentTypeRepository
    {
        public int Create(DocumentTypeEntity entity, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@DocumentType",entity.DocumentType),
                new SQLiteParameter("@Description",entity.Description)
            };

            return ExecuteScalar(query, CommandType.Text);
        }

        public DocumentTypeEntity GetEntityById(int id, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id", id)
            };

            var rowResult = ExecuteReader(query, CommandType.Text);

            DataRow row = rowResult != null ? rowResult.Rows[0] : 
                throw new Exception(/*"No se encontro ningun tipo de documento con este nombre"*/);

            DocumentTypeEntity documentEntity = new DocumentTypeEntity(
                Convert.ToInt32(row["Id"]), row["DocumentType"].ToString(), row["Description"].ToString());

            return documentEntity;
        }

        public IEnumerable<DocumentTypeEntity> GetEntities(string query)
        {
            List<DocumentTypeEntity> documentTypeEntities = new List<DocumentTypeEntity>();
            DataTable tableResults = ExecuteReader(query, CommandType.Text);

            foreach (DataRow row in tableResults.Rows)
            {
                documentTypeEntities.Add(new DocumentTypeEntity(
                    int.Parse(row["Id"].ToString()),
                    row["DocumentType"].ToString(),
                    row["Description"].ToString()));
            };

            return documentTypeEntities;
        }

        public bool Remove(int id, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",id)
            };

            return ExecuteNonQuery(query, CommandType.Text);
        }

        public bool Update(DocumentTypeEntity entity, string query)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",entity.Id),
                new SQLiteParameter("@DocumentType",entity.DocumentType),
                new SQLiteParameter("@Description",entity.Description)
            };

            return ExecuteNonQuery(query, CommandType.Text);
        }
    }
}
