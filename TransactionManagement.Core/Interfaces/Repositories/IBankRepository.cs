using System.Collections.Generic;
using TransactionManagement.Core.Entities.BankAggregate;

namespace TransactionManagement.Core.Interfaces.Repositories
{
    public interface IBankRepository : IBaseRepository<BankEntity>
    {
        int CreateBankAccount(BankAccountEntity bankAccountEntity, string script);

        bool RemoveBankAccount(int id, string script);

        bool UpdateBankAccount(BankAccountEntity bankAccountEntity, string script);

        BankAccountEntity GetBankAccountEntityById(int id, string script);

        IEnumerable<BankAccountEntity> GetBankAccountEntities(string script);

        IEnumerable<BankAccountEntity> GetBankAccountsEntitiesByBankId(int bankId, string script);
    }
}
