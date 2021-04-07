namespace TransactionManagement.Core.Queries
{
    public static class BankScripts
    {
        public static string CreateBankEntity => "INSERT INTO Bank(BankName, Phone, City, Address) VALUES(@BankName, @Phone, @City, @Address); select last_insert_rowid();";

        public static string RemoveBankEntity => "DELETE FROM Bank WHERE Id = @Id";

        public static string UpdateBankEntitye =>
            @"UPDATE Bank SET BankName = @BankName, Phone = @Phone, City = @City, Address = @Address WHERE Id = @Id";

        public static string GetBankEntities => "SELECT Id, BankName, Phone, City, Address FROM Bank;";

        public static string GetBankById => "SELECT Id, BankName, Phone, City, Address FROM Bank WHERE Id = @Id;";

        public static string CreateBankAccountEntity =>
            "INSERT INTO BankAccount(AccountNumber, Balance, BalanceInTransit, BalanceAvailable, AccountType, BankId, Incumbent, IsItLocked) VALUES(@AccountNumber, @Balance, @BalanceInTransit, @BalanceAvailable, @AccountType, @BankId, @Incumbent, @IsItLocked); select last_insert_rowid();";

        public static string RemoveBankAccountEntity => "DELETE FROM BankAccount WHERE Id = @Id;";

        public static string UpdateBankAccountEntity =>
            "UPDATE BankAccount SET AccountNumber = @AccountNumber, Balance = @Balance, BalanceInTransit = @BalanceInTransit, BalanceAvailable = @BalanceAvailable, AccountType = @AccountType, BankId = @BankId, Incumbent = @Incumbent, IsItLocked = @IsItLocked WHERE Id = @Id;";

        public static string GetBankAccountById =>
            "SELECT Id, AccountNumber, Balance, BalanceInTransit, BalanceAvailable, AccountType, BankId, Incumbent, IsItLocked FROM BankAccount WHERE Id = @Id;";

        public static string GetBankAccountsEntities =>
            "SELECT Id, AccountNumber, Balance, BalanceInTransit, BalanceAvailable, AccountType, BankId, Incumbent, IsItLocked FROM BankAccount;";

        public static string GetBankAccountsEntitiesByBankId =>
            "SELECT Id, AccountNumber, Balance, BalanceInTransit, BalanceAvailable, AccountType, BankId, Incumbent, IsItLocked FROM BankAccount WHERE BankId = @BankId;";
    }
}
