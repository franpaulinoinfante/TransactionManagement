using System;

namespace TransactionManagement.Core.Entities
{
    public class DocumentTypeEntity : BaseEntity<int>
    {
        public DocumentTypeEntity(int id, string documentType, string description) : base(id)
        {
            DocumentType = !string.IsNullOrWhiteSpace(documentType) ? documentType : throw new ArgumentNullException(nameof(documentType), "Debe de ingressar un tipo de Documento");
            Description = description;
        }

        public string DocumentType { get; private set; }

        public string Description { get; private set; }

        public void UpdateDocument(string documentType, string description)
        {
            if (string.IsNullOrWhiteSpace(documentType))
            {
                throw new ArgumentNullException(nameof(documentType), "Debe de ingressar un tipo de Documento");
            }

            DocumentType = documentType;
            Description = description;
        }
    }
}
