using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.BankAggregate;

namespace TransactionManagement.Core.Entities.PersonAggregate
{
    public class IncumbentEntity : PersonEntity
    {
        private readonly List<Bank> _banks = new List<Bank>();

        public IncumbentEntity(int id, string incumbentType) : base(id)
        {
            IncumbentType = incumbentType;
        }

        public IncumbentEntity(int id, string firstName, string lastName, string gender, string phone, string city, 
            string address, int documentTypeId, string documentCode, string incumbentType) 
            : base(id, firstName, lastName, gender, phone, city, address, documentTypeId, documentCode)
        {
            IncumbentType = !string.IsNullOrWhiteSpace(incumbentType) ? incumbentType : 
                throw new ArgumentException("Debe de indicar si es personal o de la empresa", nameof(incumbentType));
        }

        public string IncumbentType { get; private set; }

        public IReadOnlyCollection<Bank> Banks => _banks.AsReadOnly();

        public void AddIncumbent(int id, string firstName, string lastName, string gender, string phone, string city, string address,
            int documentTypeId, string documentCode, string incumbentType)
        {
            FirstName = !string.IsNullOrWhiteSpace(firstName) ? firstName : throw new ArgumentNullException(nameof(firstName));
            LastName = !string.IsNullOrWhiteSpace(lastName) ? lastName : throw new ArgumentNullException("Debe de digitar un apellido");
            Gender = !string.IsNullOrWhiteSpace(gender) ? gender : throw new ArgumentNullException("Debe de digitar el sexo");
            Phone = phone;
            City = city;
            Address = address;
            DocumentTypeId = documentTypeId;
            DocumentCode = documentCode;
            IncumbentType = !string.IsNullOrWhiteSpace(incumbentType) ? incumbentType : throw new ArgumentNullException("Debe de digitar el sexo");
        }

        public void UpdateIncumbent(string incumbentType)
        {
            IncumbentType = !string.IsNullOrWhiteSpace(incumbentType) ? incumbentType : 
                throw new ArgumentException("Debe de indicar si es personal o de la empresa", nameof(incumbentType));
        }

        public IReadOnlyCollection<Bank> BanksWithAccounts()
        {

            return null;
        }
    }
}
