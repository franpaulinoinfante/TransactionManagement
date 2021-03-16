using System;

namespace TransactionManagement.Core.Entities.PersonAggregate
{
    public class PersonEntity : BaseEntity<int>
    {
        public PersonEntity(int id) : base(id)
        {
        }

        public PersonEntity(int id, string firstName, string lastName, string gender, string phone,
            string city, string address, int? documentTypeId, string documentCode) : base(id)
        {

            FirstName = !string.IsNullOrWhiteSpace(firstName) ? firstName : throw new ArgumentNullException($"{ nameof(firstName) }", $"No puede ser un espacio en blanco ");
            LastName = !string.IsNullOrWhiteSpace(lastName) ? lastName : throw new ArgumentNullException("Debe de digitar un apellido");
            Gender = !string.IsNullOrWhiteSpace(gender) ? gender : throw new ArgumentNullException("Debe de digitar el sexo");
            Phone = phone;
            City = city;
            Address = address;
            DocumentTypeId = documentTypeId;
            DocumentCode = documentCode;
        }

        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }

        public string Gender { get; protected set; }

        public string Phone { get; set; }

        public string City { get; protected set; }

        public string Address { get; protected set; }

        public int? DocumentTypeId { get; protected set; }

        public string DocumentCode { get; protected set; }

        public void UpdatePerson(string firstName, string lastName, string gender, string phone,
            string city, string address, int? documentTypeId, string documentCode)
        {
            FirstName = !string.IsNullOrWhiteSpace(firstName) ? firstName : throw new Exception("Debe de digitar un nombre");
            LastName = !string.IsNullOrWhiteSpace(lastName) ? lastName : throw new Exception("Debe de digitar un apellido");
            Gender = !string.IsNullOrWhiteSpace(gender) ? gender : throw new ArgumentNullException("Debe de digitar el sexo");
            Phone = phone;
            City = city;
            Address = address;
            DocumentTypeId = documentTypeId;
            DocumentCode = documentCode;

        }
    }
}
