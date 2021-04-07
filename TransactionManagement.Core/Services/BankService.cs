using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.BankAggregate;
using TransactionManagement.Core.Interfaces.Services;

namespace TransactionManagement.Core.Services
{
    public class BankService : IBankService
    {
        public void SetBankAccount(IEnumerable<BankEntity> bankEntities, IEnumerable<BankAccountEntity> bankAccounts)
        {
            List<BankAccountEntity> accountByBank = new List<BankAccountEntity>();

            foreach (var bankEntity in bankEntities)
            {
                foreach (var bankAccount in bankAccounts)
                {
                    if (bankEntity.Id == bankAccount.BankId)
                    {
                        accountByBank.Add(bankAccount);
                    }
                }

                bankEntity.SetBankAccounts(accountByBank);
                accountByBank.Clear();
            }
        }

        public void SetBankAccount(BankEntity bankEntity, IEnumerable<BankAccountEntity> bankAccounts)
        {
            foreach (var bankAccount in bankAccounts)
            {
                if (bankEntity.Id == bankAccount.BankId)
                {
                    bankEntity.SetBankAccount(bankAccount);
                }
            }
        }
    }
}
