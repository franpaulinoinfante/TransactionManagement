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
        void PerformTransfer(BankAccount incumbenBankAcount, TransactionStatus transactionStatus, decimal amount);

        void ChangeMoneyComplete(BankAccount incumbenBankAcount, TransactionStatus transactionStatus, string ReferenceNumber);
    }
}
