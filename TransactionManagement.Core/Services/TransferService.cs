using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.BankAggregate;

namespace TransactionManagement.Core.Services
{
    class TransferService : Interfaces.ITransferService
    {
        public void PerformTransfer(BankAccount incumbenBankAcount, TransactionStatus transactionStatus, decimal amount)
        {
            incumbenBankAcount.ChangeMoneyInTransit(transactionStatus, amount);
        }

        public void ChangeMoneyComplete(BankAccount incumbenBankAcount, TransactionStatus transactionStatus, string ReferenceNumber)
        {

        }
    }
}
