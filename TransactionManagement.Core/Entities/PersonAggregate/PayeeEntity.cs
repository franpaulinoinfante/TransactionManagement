using System;
using System.Collections.Generic;
using TransactionManagement.Core.Entities.BankAggregate;

namespace TransactionManagement.Core.Entities.PersonAggregate
{
    public class PayeeEntity : PersonEntity
    {
        private List<Transaction> _transactions = new List<Transaction>();

        public PayeeEntity(int id) : base(id)
        {
        }

        public PayeeEntity(int id, string firstName, string lastName, string gender, string phone,
            string city, string address, int? documentTypeId, string documentCode, string typeOfPayee) 
            : base(id, firstName, lastName, gender, phone, city, address, documentTypeId, documentCode)
        {
            TypeOfPayee = !string.IsNullOrWhiteSpace(typeOfPayee) ? typeOfPayee : throw new ArgumentException("Debe de indicar de benificiario", nameof(typeOfPayee));
        }


        public string TypeOfPayee { get; private set; }

        public string Description { get; private set; }

        public void UpdateTypeOfPayee(string typeOfPayee, string description)
        {
            TypeOfPayee = !string.IsNullOrWhiteSpace(typeOfPayee) ? typeOfPayee : throw new ArgumentException("Debe de indicar de benificiario", nameof(typeOfPayee));

            Description = !string.IsNullOrWhiteSpace(description) ? description : throw new ArgumentException("Debe de indicar de benificiario", nameof(description));
        }

        public void RevomeDescription()
        {
            Description = string.Empty;
        }

        public IReadOnlyCollection<Transaction> Transactions => _transactions.AsReadOnly();

        public void UpdateTypeOfPayee(string typeOfPayee)
        {
            TypeOfPayee = typeOfPayee ?? throw new System.ArgumentException(nameof(typeOfPayee));
        }


    }
}
