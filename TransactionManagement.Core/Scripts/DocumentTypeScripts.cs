using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Queries
{
    public static class DocumentTypeQueries
    {
        public static string GetDocumentTypes => "SELECT Id, DocumentType, Description FROM DocumentType";

        public static string GetDocumentTypeByDocumentType => @"SELECT Id, DocumentType, Description FROM DocumentType WHERE Id = @Id";

        public static string CreateDocumentType =>
            @"INSERT INTO DocumentType(DocumentType, Description) VALUES(@DocumentType, @Description); select last_insert_rowid();";

        public static string UpdateDocumentType =>
            @"UPDATE DocumentType SET DocumentType = @DocumentType, Description = @Description WHERE Id = @Id";

        public static string RemoveDocumentType => @"DELETE FROM DocumentType WHERE Id = @Id";
    }
}
