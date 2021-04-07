using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Entities
{
    public class UserEntity : BaseEntity<int>
    {
        public UserEntity(int id, string userName, string password, string firstName, string lastName, string gender, int documentTypeId, string documentCode, string phone, string city, string address) : base(id)
        {
            FirstName = firstName; // !string.IsNullOrWhiteSpace(firstName) ? firstName : throw new ArgumentNullException();
            LastName = lastName; //!string.IsNullOrWhiteSpace(lastName) ? lastName : throw new ArgumentNullException(); 
            Gender = gender; // !string.IsNullOrWhiteSpace(gender) ? gender : throw new ArgumentNullException(); 
            DocumentTypeId = documentTypeId;
            DocumentCode = documentCode;
            Phone = phone;
            City = city;
            Address = address;
            UserName = userName;
            Password = password;
        }

        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Gender { get; private set; }
        
        public int DocumentTypeId { get; private set; }
        public DocumentTypeEntity DocumentType { get; private set; }
        
        public string DocumentCode { get; private set; }
        public string Phone { get; private set; }
        public string City { get; private set; }
        public string Address { get; private set; }

        public void UpdateUser(string userName, string password, string firstName, string lastName, string gender, int documentTypeId, string documentCode, string phone, string city, string address)
        {
            UserName = !string.IsNullOrWhiteSpace(userName) ? userName : throw new ArgumentNullException();
            Password = !string.IsNullOrWhiteSpace(password) ? password : throw new ArgumentNullException(); ;
            FirstName = !string.IsNullOrWhiteSpace(firstName) ? firstName : throw new ArgumentNullException(); ;
            LastName = !string.IsNullOrWhiteSpace(lastName) ? lastName : throw new ArgumentNullException(); ;
            Gender = gender;
            DocumentTypeId = documentTypeId;
            DocumentCode = documentCode;
            Phone = phone;
            City = city;
            Address = address;
        }

        public void SetUserAccount(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Debe ingresar un usuario y una contraseña");
            }

            UserName = userName;
            Password = password;
        }

        public void SetDocumentType(DocumentTypeEntity documentTypeEntity)
        {
            if (documentTypeEntity == null)
            {
                throw new ArgumentException();
            }

            if (DocumentTypeId == documentTypeEntity.Id)
            {
                DocumentType = documentTypeEntity;
            }            
        }

        public void SetDocumentType(int documentTypeId)
        {
            if (documentTypeId == 0)
            {
                throw new Exception();
            }

            DocumentTypeId = documentTypeId;
        }

        public void SetDocumentCode(string documentCode)
        {
            DocumentCode = !string.IsNullOrWhiteSpace(documentCode) ? documentCode : throw new ArgumentNullException();
        }

        public void UpdateDocumentData(int documentTypeId, string documentCode)
        {
            if ((documentTypeId == 0) || (documentCode == null))
            {
                throw new Exception();
            }

            DocumentTypeId = documentTypeId;
            DocumentCode = documentCode;
        }
    }
}
