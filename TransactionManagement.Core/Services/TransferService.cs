using TransactionManagement.Core.Entities.BankAggregate;

namespace TransactionManagement.Core.Services
{
    public class TransferService : Interfaces.ITransferService
    {
        public void PerformTransferInTransitBetweenAccount(TransactionStatus transactionStatus, BankAccountEntity originAccount, BankAccountEntity destinationAccount, decimal amount)
        {
            if (originAccount == null || destinationAccount == null)
            {
                throw new System.NullReferenceException("debe enviar una cuenta ");
            }

            originAccount.ChargeMoneyInTransit(transactionStatus, amount);

            destinationAccount.CreditMoney(amount);
        }

        public void PerformTransferInTransitForPayee(TransactionStatus transactionStatus, BankAccountEntity originAccount, decimal amount)
        {
            if (originAccount == null || transactionStatus == null)
            {
                throw new System.NullReferenceException("debe enviar una cuenta ");
            }

            originAccount.ChargeMoneyInTransit(transactionStatus, amount);
        }

        public void PerformTransferComplete(BankAccountEntity originAccount, Transaction transaction)
        {
            if (originAccount == null || transaction == null)
            {
                throw new System.NullReferenceException("debe enviar una cuenta y la transacción");
            }

            originAccount.ChargeMoneyComplete(transaction);


        }

        public void PerfomTransferCreditMoney(BankAccountEntity originAccount, decimal amount)
        {
            if (originAccount == null)
            {
                throw new System.NullReferenceException("debe enviar una cuenta");
            }

            originAccount.CreditMoney(amount);
        }
    }
}
