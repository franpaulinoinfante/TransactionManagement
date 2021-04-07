using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.BankAggregate;

namespace TransactionManagement.Core.Interfaces.Services
{
    public interface IBankService
    {
        void SetBankAccount(IEnumerable<BankEntity> bankEntities, IEnumerable<BankAccountEntity> bankAccounts);

        void SetBankAccount(BankEntity bankEntity, IEnumerable<BankAccountEntity> bankAccounts);
    }
}
