namespace TransactionManagement.Core.Entities.PersonAggregate
{
    public abstract class Person : BaseEntity<int>
    {
        protected Person(int id, string firstName, string lastName, char gender) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }

        protected Person(int id, string firstName, string lastName, char gender, string phone,
            string city, string address, int documentTypeId) : base(id)
        {

            FirstName = !string.IsNullOrWhiteSpace(firstName) ? firstName : throw new System.ArgumentNullException(nameof(firstName));
            LastName = !string.IsNullOrWhiteSpace(lastName) ? lastName : throw new System.ArgumentNullException("Debe de digitar un apellido");
            Gender = gender;
            Phone = phone;
            City = city;
            Address = address;
            DocumentTypeId = documentTypeId;
        }

        protected string FirstName { get; private set; }

        protected string LastName { get; private set; }

        protected char Gender { get; set; }

        protected string Phone { get; set; }

        protected string City { get; set; }

        protected string Address { get; set; }

        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }

        public void UpdatePerson(string firstName, string lastName, char gender, string phone,
            string city, string address, int documentTypeId)
        {
            FirstName = !string.IsNullOrWhiteSpace(firstName) ? firstName : throw new System.Exception("Debe de digitar un nombre");
            LastName = !string.IsNullOrWhiteSpace(lastName) ? lastName : throw new System.Exception("Debe de digitar un apellido");
            Gender = gender;
            Phone = phone;
            City = city;
            Address = address;
            DocumentTypeId = documentTypeId;
        }

        public void SetDocumentType(DocumentType documentType)
        {
            if (documentType != null)
            {
                DocumentType = documentType;
            }
        }
    }
}
