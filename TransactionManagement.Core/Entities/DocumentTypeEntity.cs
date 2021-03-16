namespace TransactionManagement.Core.Entities
{
    public class DocumentTypeEntity : BaseEntity<int>
    {
        public DocumentTypeEntity(int id, string documentType, string description) : base(id)
        {
            DocumentType = documentType; //!string.IsNullOrWhiteSpace(documentType) ? documentType :                 throw new System.ArgumentNullException(nameof(documentType), "Debe de ingressar un tipo de Documento");
            Description = description;
        }

        public string DocumentType { get; private set; }

        public string Description { get; private set; }

        public void UpdateDocument(string documentType, string description)
        {
            if (string.IsNullOrWhiteSpace(documentType))
            {
                throw new System.ArgumentNullException($"El tipo de documento - { nameof(documentType) } no puede ser un espacio en blanco!");
            }

            DocumentType = documentType;
            Description = description;
        }
    }
}
