using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.BankAggregate;

namespace TransactionManagement.Core.Interfaces
{
    public interface ITransferService
    {
        void PerformTransferInTransitBetweenAccount(TransactionStatus transactionStatus, BankAccountEntity originAccount, BankAccountEntity destinationAccount, decimal amount);

        void PerformTransferInTransitForPayee(TransactionStatus transactionStatus, BankAccountEntity originAccount, decimal amount);

        void PerformTransferComplete(BankAccountEntity originAccount, Transaction transaction);

        void PerfomTransferCreditMoney(BankAccountEntity originAccount, decimal amount);
    }
}
