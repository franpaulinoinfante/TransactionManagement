using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using TransactionManagement.Core.Entities.BankAggregate;
using TransactionManagement.Core.Interfaces.Repositories;

namespace TransactionManagement.Infrastructure.Repositories
{
    public class BankRepository : MasterRepository, IBankRepository
    {
        public int Create(BankEntity entity, string script)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@BankName",entity.BankName),
                new SQLiteParameter("@Phone",entity.Phone),
                new SQLiteParameter("@City",entity.City),
                new SQLiteParameter("@Address",entity.Address)
            };

            return ExecuteScalar(script, CommandType.Text);
        }

        public bool Remove(int id, string script)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",id)
            };

            return ExecuteNonQuery(script, CommandType.Text);
        }

        public bool Update(BankEntity entity, string script)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("Id", entity.Id),
                new SQLiteParameter("@BankName",entity.BankName),
                new SQLiteParameter("@Phone",entity.Phone),
                new SQLiteParameter("@City",entity.City),
                new SQLiteParameter("@Address",entity.Address)
            };

            return ExecuteNonQuery(script, CommandType.Text);
        }

        public BankEntity GetEntityById(int id, string script)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",id)
            };

            DataTable tableResult = ExecuteReader(script, CommandType.Text);
            if (tableResult.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = tableResult.Rows[0];
            return new BankEntity(
                Convert.ToInt32(row["Id"]),
                row["BankName"].ToString(),
                row["Phone"].ToString(),
                row["City"].ToString(),
                row["Address"].ToString());
        }

        public IEnumerable<BankEntity> GetEntities(string script)
        {
            List<BankEntity> bankEntities = new List<BankEntity>();
            DataTable tableResult = ExecuteReader(script, CommandType.Text);

            foreach (DataRow row in tableResult.Rows)
            {
                bankEntities.Add(new BankEntity(
                    Convert.ToInt32(row["Id"].ToString()),
                    row["BankName"].ToString(),
                    row["Phone"].ToString(),
                    row["City"].ToString(),
                    row["Address"].ToString()));
            }

            return bankEntities;
        }

        // Bank Account Repository
        public int CreateBankAccount(BankAccountEntity bankAccount, string script)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@AccountNumber",bankAccount.AccountNumber),
                new SQLiteParameter("@Balance",bankAccount.Balance),
                new SQLiteParameter("@BalanceInTransit",bankAccount.BalanceInTransit),
                new SQLiteParameter("@BalanceAvailable",bankAccount.BalanceAvailable),
                new SQLiteParameter("@AccountType",bankAccount.AccountType),
                new SQLiteParameter("@BankId",bankAccount.BankId),
                new SQLiteParameter("@IsItLocked",bankAccount.IsItLocked),
                new SQLiteParameter("@Incumbent",bankAccount.Incumbent)
            };

            return ExecuteScalar(script, CommandType.Text);
        }

        public bool RemoveBankAccount(int id, string script)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",id)
            };

            return ExecuteNonQuery(script, CommandType.Text);
        }

        public bool UpdateBankAccount(BankAccountEntity bankAccount, string script)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",bankAccount.Id),
                new SQLiteParameter("@AccountNumber",bankAccount.AccountNumber),
                new SQLiteParameter("@Balance",bankAccount.Balance),
                new SQLiteParameter("@BalanceInTransit",bankAccount.BalanceInTransit),
                new SQLiteParameter("@BalanceAvailable",bankAccount.BalanceAvailable),
                new SQLiteParameter("@AccountType",bankAccount.AccountType),
                new SQLiteParameter("@BankId",bankAccount.BankId),
                new SQLiteParameter("@IsItLocked",bankAccount.IsItLocked),
                new SQLiteParameter("@Incumbent",bankAccount.Incumbent)
            };

            return ExecuteNonQuery(script, CommandType.Text);
        }

        public BankAccountEntity GetBankAccountEntityById(int id, string script)
        {
            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Id",id)
            };

            DataTable tableResult = ExecuteReader(script, CommandType.Text);
            if (tableResult.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = tableResult.Rows[0];

            return new BankAccountEntity(
                Convert.ToInt32(row[""].ToString()),
                row["AccountNumber"].ToString(),
                Convert.ToDecimal(row["Balance"].ToString()),
                Convert.ToDecimal(row["BalanceInTransit"].ToString()),
                Convert.ToDecimal(row["BalanceAvailable"].ToString()),
                row["AccountType"].ToString(),
                Convert.ToInt32(row["BankId"].ToString()),
                row["Incumbent"].ToString(),
                Convert.ToBoolean(row["isItLocked"]));
        }

        public IEnumerable<BankAccountEntity> GetBankAccountEntities(string script)
        {
            List<BankAccountEntity> bankAccounts = new List<BankAccountEntity>();
            DataTable tableResult = ExecuteReader(script, CommandType.Text);

            foreach (DataRow row in tableResult.Rows)
            {
                BankAccountEntity bankAccount = new BankAccountEntity(
                    Convert.ToInt32(row["Id"].ToString()),
                    row["AccountNumber"].ToString(),
                    Convert.ToDecimal(row["Balance"].ToString()),
                    Convert.ToDecimal(row["BalanceInTransit"].ToString()),
                    Convert.ToDecimal(row["BalanceAvailable"].ToString()),
                    row["AccountType"].ToString(),
                    Convert.ToInt32(row["BankId"].ToString()),
                    row["Incumbent"].ToString(),
                    Convert.ToBoolean(row["isItLocked"]));

                bankAccounts.Add(bankAccount);
            }

            return bankAccounts;
        }

        public IEnumerable<BankAccountEntity> GetBankAccountsEntitiesByBankId(int bankId, string script)
        {
            List<BankAccountEntity> bankAccounts = new List<BankAccountEntity>();

            _parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@BankId", bankId)
            };

            DataTable tableResult = ExecuteReader(script, CommandType.Text);

            foreach (DataRow row in tableResult.Rows)
            {
                BankAccountEntity bankAccount = new BankAccountEntity(
                    Convert.ToInt32(row["Id"].ToString()),
                    row["AccountNumber"].ToString(),
                    Convert.ToDecimal(row["Balance"].ToString()),
                    Convert.ToDecimal(row["BalanceInTransit"].ToString()),
                    Convert.ToDecimal(row["BalanceAvailable"].ToString()),
                    row["AccountType"].ToString(),
                    Convert.ToInt32(row["BankId"].ToString()),
                    row["Incumbent"].ToString(),
                    Convert.ToBoolean(row["isItLocked"]));

                bankAccounts.Add(bankAccount);
            }

            return bankAccounts;
        }
    }
}
