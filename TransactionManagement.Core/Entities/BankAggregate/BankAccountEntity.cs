using System;
using System.Collections.Generic;
using TransactionManagement.Core.Entities.PersonAggregate;

namespace TransactionManagement.Core.Entities.BankAggregate
{
    public class BankAccountEntity : BaseEntity<int>
    {
        private readonly List<Transaction> _transactions = new List<Transaction>();

        public BankAccountEntity(
            int id, 
            string accountNumber, 
            decimal balance, 
            decimal balanceInTransit, 
            decimal balanceAvailable, 
            string accountType, 
            int bankId, 
            string incumbent,
            bool isItLocked) : base(id)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            BalanceInTransit = balanceInTransit;
            BalanceAvailable = balanceAvailable;
            AccountType = accountType;
            BankId = bankId;
            IsItLocked = isItLocked;
            Incumbent = incumbent;
        }

        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public decimal BalanceInTransit { get; private set; }
        public decimal BalanceAvailable { get; private set; }
        public bool IsItLocked { get; private set; }
        public string AccountType { get; private set; }
        public string Incumbent { get; private set; }
        public int BankId { get; private set; }
        public BankEntity bank { get; private set; }

        public void UpdateAccount(string accountNumber, decimal balance, decimal balanceInTransit, decimal balanceAvailable, Boolean isItLocked, string accountType, string incumbent, int bankId)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            BalanceInTransit = balanceInTransit;
            BalanceAvailable = balanceAvailable;
            IsItLocked = isItLocked;
            AccountType = accountType;
            Incumbent = incumbent;
            BankId = bankId;
        }

        /// <summary>
        /// Method that return a transactions' list
        /// </summary>
        public IReadOnlyCollection<Transaction> GetTransactions => _transactions.AsReadOnly();

        public IReadOnlyCollection<Transaction> GetTransactionsByRateDate(DateTime dateBegin, DateTime dateEnd)
        {
            List<Transaction> transactions = new List<Transaction>();

            foreach (Transaction item in GetTransactions)
            {
                while (dateBegin.Date >= item.DateTransferEnd && dateEnd.Date <= item.DateTransferEnd)
                {
                    transactions.Add(item);
                }
            }

            return transactions;
        }

        public void ChargeMoneyInTransit(TransactionStatus transactionStatus, decimal amount)
        {
            if (transactionStatus == null)
            {
                throw new NullReferenceException($"Debe de seleccionar un estado - {nameof(transactionStatus)}");
            }

            if (amount <= 0)
            {
                throw new ArgumentException("El valor no puede ser menor o igual a cero", nameof(amount));
            }

            if (BalanceAvailable <= amount)
            {
                throw new ArgumentException("No tiene balance suficiente", nameof(BalanceAvailable));
            }


            if (transactionStatus.Id == (int)Enums.TransactionStatusEnum.InTransit)
            {
                BalanceInTransit += amount;
                BalanceAvailable = Balance - BalanceInTransit;
            }
        }

        public void ChargeMoneyComplete(Transaction transaction)
        {
            if (transaction == null)
            {
                throw new NullReferenceException($"Esta transacción - { nameof(transaction) }, no existe");
            }

            if (transaction.Id == (int)Enums.TransactionStatusEnum.Complete)
            {
                BalanceInTransit -= transaction.Amount;
                Balance -= transaction.Amount;
            }
        }

        public void CreditMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception($"debe ingresar un valor mayor que cero {nameof(amount)}");
            }

            Balance += amount;
            BalanceAvailable = Balance - BalanceInTransit;
        }
    }
}
