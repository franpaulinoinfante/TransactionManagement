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
        public Bank(int id, string bankName, string phone, string city, string address) : base(id)
        {
            BankName = bankName;
            Phone = phone;
            City = city;
            Address = address;
        }

        public string BankName { get; private set; }

        public string Phone { get; private set; }

        public string City { get; private set; }

        public string Address { get; private set; }

        /// <summary>
        /// Method that return a Account's list
        /// </summary>
        public IReadOnlyCollection<BankAccount> GetAccounts => _bankAccounts.AsReadOnly();

        public void CreateAccount()
        {


        }
    }
}
