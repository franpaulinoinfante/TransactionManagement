namespace TransactionManagement.ApplicationService.Adapters.DTOs
{
    public class BankAccountDto
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal BalanceInTransit { get; set; }
        public decimal BalanceAvailable { get; set; }
        public bool IsItLocked { get; set; }
        public string AccountType { get; set; }
        public string Incumbent { get; set; }
        public int BankId { get; set; }
    }
}
