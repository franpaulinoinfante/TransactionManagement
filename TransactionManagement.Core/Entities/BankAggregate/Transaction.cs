using System;
using TransactionManagement.Core.Entities.PersonAggregate;

namespace TransactionManagement.Core.Entities.BankAggregate
{
    public class Transaction : BaseEntity<int>
    {
        public Transaction(int id, string referenceNumber, decimal amount, DateTime dateTransferStarted, DateTime? dateTransferEnd, string description, int userId, int originalBankAccountId, int transactionStatusId, int? payeeId, int? finalBankAccountId) : base(id)
        {
            ReferenceNumber = referenceNumber;
            Amount = amount;
            DateTransferStarted = dateTransferStarted;
            DateTransferEnd = dateTransferEnd;
            Description = description;
            UserId = userId;
            OriginalBankAccountId = originalBankAccountId;
            TransactionStatusId = transactionStatusId;
            PayeeId = payeeId;
            FinalBankAccountId = finalBankAccountId;
        }

        public string ReferenceNumber { get; private set; }

        public decimal Amount { get; private set; }

        public DateTime DateTransferStarted { get; private set; }

        public DateTime? DateTransferEnd { get; private set; }

        public string Description { get; private set; }

        public int UserId { get; private set; }

        public int OriginalBankAccountId { get; private set; }
        public BankAccountEntity OriginalBankAccount { get; private set; }

        public int? FinalBankAccountId { get; private set; }
        public BankAccountEntity FnalBankAccount { get; private set; }

        public int TransactionStatusId { get; private set; }
        public TransactionStatus TransactionStatus { get; private set; }

        public int? PayeeId { get; private set; }

        public void UpdateTransferStatus(int transactionStatusId)
        {
            if (transactionStatusId <= 0)
            {
                throw new Exception();
            }

            TransactionStatusId = transactionStatusId;
            DateTransferEnd = DateTime.Now;
        }

        public void ChangeTransactionStatus(TransactionStatus transactionStatus)
        {
            TransactionStatus = transactionStatus ?? throw new NullReferenceException();
        }
    }
}
