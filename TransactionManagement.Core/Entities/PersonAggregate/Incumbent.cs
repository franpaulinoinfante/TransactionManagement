using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.BankAggregate;

namespace TransactionManagement.Core.Entities.PersonAggregate
{
    public class Incumbent : Person
    {
        private readonly List<BankAccount> _bankAccounts = new List<BankAccount>();

        public Incumbent(int id, string firstName, string lastName, char gender) : base(id, firstName,lastName,gender)
        {

        }

        public Incumbent(int id, string firstName, string lastName, char gender, string phone, string city, string address, 
            int documentTypeId) : base(id,firstName,lastName,gender,phone,city,address,documentTypeId)
        {

        }

        public void AddAccount()
        {

        }

        public IReadOnlyCollection<BankAccount> GetBankAccounts => _bankAccounts.AsReadOnly();

        public IReadOnlyCollection<BankAccount> GetBankAccountsByBank (string bankName)
        {
            return _bankAccounts.Where(a => a.Bank.BankName == bankName).ToList();
        }

        public BankAccount GetBankAccountByAccountNumber(string accountNumber)
        {
            return _bankAccounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
        }
    }
}
