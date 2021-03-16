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
        void PerformTransferInTransitBetweenAccount(TransactionStatus transactionStatus, BankAccount originAccount, BankAccount destinationAccount, decimal amount);

        void PerformTransferInTransitForPayee(TransactionStatus transactionStatus, BankAccount originAccount, decimal amount);

        void PerformTransferComplete(BankAccount originAccount, Transaction transaction);

        void PerfomTransferCreditMoney(BankAccount originAccount, decimal amount);
    }
}
