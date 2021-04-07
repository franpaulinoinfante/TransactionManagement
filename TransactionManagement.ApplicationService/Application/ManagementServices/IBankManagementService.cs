using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.ApplicationService.Adapters.DTOs;

namespace TransactionManagement.ApplicationService.Application.ManagementServices
{
    public interface IBankManagementService
    {
        int CreateBank(BankDto bankDto);

        void RemoveBank(int id);

        void UpdateBank(BankDto bankDto);

        BankDto GetBankDtoById(int id);

        BankDto GetBankWithAccountsDtosById(int bankId);

        IEnumerable<BankDto> GetBankDtos();

        IEnumerable<BankDto> GetBankWithAccountsDtos();

        int CreateBankAccount(BankAccountDto bankAccountDto);

        void RemoveBankAccount(int id);

        void UpdateBankAccount(BankAccountDto bankAccountDto);

        IEnumerable<BankAccountDto> GetBankAccountDtos();

        IEnumerable<BankAccountDto> GetBankAccountDtoByIdOrBankId(int id);
    }
}
