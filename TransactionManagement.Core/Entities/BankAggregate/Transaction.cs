using System;
using TransactionManagement.Core.Entities.PersonAggregate;

namespace TransactionManagement.Core.Entities.BankAggregate
{
    public class Transaction : BaseEntity<int>
    {
        public Transaction(int id, string referenceNumber, decimal amount, DateTime dateTransferStarted, DateTime? dateTransferEnd,
            string description, int userId, int bankAccountId, int transactionStatusId, int payeeId) : base(id)
        {
            ReferenceNumber = referenceNumber;
            Amount = amount;
            DateTransferStarted = dateTransferStarted;
            DateTransferEnd = dateTransferEnd;
            Description = description;
            UserId = userId;
            BankAccountId = bankAccountId;
            TransactionStatusId = transactionStatusId;
            PayeeId = payeeId;
        }

        public string ReferenceNumber { get; set; }

        public decimal Amount { get; set; }

        public DateTime DateTransferStarted { get; set; }

        public DateTime? DateTransferEnd { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public int BankAccountId { get; set; }

        public int TransactionStatusId { get; set; }

        public int PayeeId { get; set; }

        public void UpdateTransferStatus(int transactionStatusId)
        {
            if (transactionStatusId <= 0)
            {
                throw new Exception();
            }

            TransactionStatusId = transactionStatusId;
            DateTransferEnd = DateTime.Now;
        }
    }
}
