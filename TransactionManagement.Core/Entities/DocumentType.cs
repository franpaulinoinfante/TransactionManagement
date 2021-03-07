namespace TransactionManagement.Core.Entities
{
    public class DocumentType : BaseEntity<int>
    {
        public DocumentType(int id) : base(id)
        {

        }

        public string TypeOfDocument { get; set; }

        public string Description { get; set; }
    }
}
