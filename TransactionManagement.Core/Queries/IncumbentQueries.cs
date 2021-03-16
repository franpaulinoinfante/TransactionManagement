namespace TransactionManagement.Core.Queries
{
    public static class IncumbentQueries
    {
        public static string CreateIncumbent => "";


        public static string RemoveIncumbent => "";


        public static string UpdateIncumbent => "";

        public static string GetIncumbentEntities =>
            @"SELECT p.Id, p.FirstName, p.LastName, p.Gender, p.DocumentTypeId,
                    p.DocumentCode, i.IncumbentType, p.Phone, p.City, p.Address
                FROM Incumbent AS i
            INNER JOIN Person AS p
                ON i.Id = p.Id;";
    }
}
