using System;
using System.Collections.Generic;
using System.Linq;
using TransactionManagement.Core.Entities.PersonAggregate;

namespace TransactionManagement.Core.Entities.BankAggregate
{
    public class BankAccount : BaseEntity<int>
    {
        private readonly List<Transaction> _transactions = new List<Transaction>();
        private readonly Transaction _newTrasaction;

        public BankAccount(int id, int incumbentId, string accountNumber, decimal balance, int productId, bool isItLocked)
            : base(id)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            IncumbentId = incumbentId;
            ProductId = productId;
            IsItLocked = isItLocked;
        }

        public BankAccount(int id, string accountNumber, decimal balance, decimal balanceInTransit,
            decimal balanceAvailable, int incumbentId, int bankId, int productId) : base(id)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            BalanceInTransit = balanceInTransit;
            BalanceAvailable = balanceAvailable;
            IncumbentId = incumbentId;
            BankId = bankId;
            ProductId = productId;
        }

        public string AccountNumber { get; set; }

        public decimal Balance { get; set; }

        public decimal BalanceInTransit { get; set; }

        public decimal BalanceAvailable { get; set; }

        public bool IsItLocked { get; private set; } = false;


        public int IncumbentId { get; set; }
        public IncumbentEntity Incumbent { get; set; }

        public int BankId { get; set; }
        public Bank bank { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }


        public void UpdateAccount(decimal balance, decimal balanceInTransit,
            decimal balanceAvailable, int incumbentId, int bankId, int productId)
        {
            Balance = balance;
            BalanceInTransit = balanceInTransit;
            BalanceAvailable = balanceAvailable;
            IncumbentId = incumbentId;
            BankId = bankId;
            ProductId = productId;
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

        // 01
        // 500,000
        // 5,000
        // 10/03/2021 - 10:41:01 AM
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


            if (transactionStatus.Description == "En transito")
            {
                BalanceInTransit += amount;
                BalanceAvailable = Balance - BalanceInTransit;
            }
        }

        //495,000
        // 10:03/2021 - 03:25:10 pm
        public void ChargeMoneyComplete(Transaction transaction)
        {
            if (transaction == null)
            {
                throw new NullReferenceException($"Esta transacción - { nameof(transaction) }, no existe");
            }

            if (transaction.Description == "Complete")
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



        private void NewTransaction(decimal amount, int id, string referenceNumber, DateTime dateTransferStarted, DateTime? dateTransferEnd, string description, int userId, int bankAccountId, int transactionStatusId, int payeeId)
        {
            //_newTrasaction = new Transaction(id, referenceNumber, amount, dateTransferStarted, dateTransferEnd, description, userId, bankAccountId, transactionStatusId, payeeId);
        }

        public void ChangeMoneyComplete(TransactionStatus transactionStatus, string referenceNumber)
        {
            if (transactionStatus == null)
            {
                throw new NullReferenceException($"Debe de seleccionar un estado - {nameof(transactionStatus)}");
            }

            if (transactionStatus.Description == "Transacción completada")
            {
                Transaction trans = _transactions.FirstOrDefault(t => t.ReferenceNumber == referenceNumber);

                _newTrasaction.UpdateTransferStatus(transactionStatus.Id);
                Balance = BalanceAvailable;
            }
        }

        public void CreateTranferForThis(int id, string referenceNumber, decimal amount, DateTime dateTransferStarted, DateTime? dateTransferEnd, string description, int userId, int bankAccountId, int transactionStatusId, int payeeId)
        {
            //_newTrasaction = new Transaction(id, referenceNumber, amount, dateTransferStarted, dateTransferEnd, description, userId, bankAccountId, transactionStatusId, payeeId);
        }
    }
}
