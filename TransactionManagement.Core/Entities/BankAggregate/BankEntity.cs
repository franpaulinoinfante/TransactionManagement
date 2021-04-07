using System;
using System.Collections.Generic;
using System.Linq;

namespace TransactionManagement.Core.Entities.BankAggregate
{
    public class BankEntity : BaseEntity<int>
    {
        private readonly List<BankAccountEntity> _bankAccounts = new List<BankAccountEntity>();

        public BankEntity(int id, string bankName, string phone, string city, string address) : base(id)
        {
            BankName = !string.IsNullOrWhiteSpace(bankName) ? bankName : throw new ArgumentException(nameof(bankName));
            Phone = !string.IsNullOrWhiteSpace(phone) ? phone : throw new ArgumentException(nameof(phone));
            City = !string.IsNullOrWhiteSpace(city) ? city : throw new ArgumentException(nameof(city));
            Address = !string.IsNullOrWhiteSpace(address) ? address : throw new ArgumentException(nameof(address));
        }

        public BankEntity(int id, string bankName, string phone, string city, string address, List<BankAccountEntity> bankAccounts)
            : base(id)
        {
            BankName = !string.IsNullOrWhiteSpace(bankName) ? bankName : throw new ArgumentException(nameof(bankName));
            Phone = !string.IsNullOrWhiteSpace(phone) ? phone : throw new ArgumentException(nameof(phone));
            City = !string.IsNullOrWhiteSpace(city) ? city : throw new ArgumentException(nameof(city));
            Address = !string.IsNullOrWhiteSpace(address) ? address : throw new ArgumentException(nameof(address));
            _bankAccounts = bankAccounts;
        }

        public string BankName { get; private set; }
        public string Phone { get; private set; }
        public string City { get; private set; }
        public string Address { get; private set; }

        /// <summary>
        /// Actualiza los campos de la entidad
        /// </summary>
        /// <param name="bankName"></param>
        /// <param name="phone"></param>
        /// <param name="city"></param>
        /// <param name="address"></param>
        public void UpdateBank(string bankName, string phone, string city, string address)
        {
            if (string.IsNullOrWhiteSpace(bankName) || string.IsNullOrWhiteSpace(phone) || 
                string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(address))                
            {
                throw new ArgumentException("Debe registrar todos los datos del banco");
            }

            BankName = bankName;
            Phone = phone;
            City = city;
            Address = address;
        }

        public void SetBankAccounts(IEnumerable<BankAccountEntity> bankAccounts)
        {
            if (bankAccounts != null)
            {
                foreach (BankAccountEntity bankAccount in bankAccounts)
                {
                    _bankAccounts.Add(bankAccount);
                }
            }
        }

        public void SetBankAccount(BankAccountEntity bankAccount)
        {
            _bankAccounts.Add(bankAccount);
        }


        public BankAccountEntity GetBankAccountByAccountNumber(string accountNumber)
        {
            return _bankAccounts.First(a => a.AccountNumber == accountNumber);
        }

        /// <summary>
        /// Method that return a Account's list
        /// </summary>
        public IReadOnlyCollection<BankAccountEntity> GetAccounts => _bankAccounts.AsReadOnly();
    }
}
