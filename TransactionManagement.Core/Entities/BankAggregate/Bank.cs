using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Entities.BankAggregate
{
    public class Bank : BaseEntity<int>
    {
        private readonly List<BankAccount> _bankAccounts = new List<BankAccount>();

        public Bank(int id, string bankName, string phone, string city, string address)
            : base(id)
        {
            BankName = !string.IsNullOrWhiteSpace(bankName) ? bankName :
                throw new ArgumentException("Debe de indicar si es personal o de la empresa", nameof(bankName));
            Phone = !string.IsNullOrWhiteSpace(phone) ? phone :
                throw new ArgumentException("Debe de indicar si es personal o de la empresa", nameof(phone));
            City = !string.IsNullOrWhiteSpace(city) ? city :
                throw new ArgumentException("Debe de indicar si es personal o de la empresa", nameof(city));
            Address = !string.IsNullOrWhiteSpace(address) ? address :
                throw new ArgumentException("Debe de indicar si es personal o de la empresa", nameof(address));
        }

        public string BankName { get; private set; }

        public string Phone { get; private set; }

        public string City { get; private set; }

        public string Address { get; private set; }

        /// <summary>
        /// Method that return a Account's list
        /// </summary>
        public IReadOnlyCollection<BankAccount> GetAccounts => _bankAccounts.AsReadOnly();

        public void CreateAccount(BankAccount bankAccount)
        {
            if (bankAccount == null)
            {
                throw new NullReferenceException(nameof(bankAccount));
            }

            _bankAccounts.Add(bankAccount);
        }
    }
}
