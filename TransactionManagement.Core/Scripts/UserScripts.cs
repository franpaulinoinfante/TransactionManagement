using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Queries
{
    public static class UserQueries
    {
        public static string GetUserById =>
             @"SELECT Id, UserName, Password, FirstName, LastName, Gender, DocumentTypeId, DocumentCode, Phone, City, Address FROM User Where Id = @Id";

        public static string GetUsers => @"SELECT Id, UserName, Password, FirstName, LastName, Gender, DocumentTypeId, DocumentCode, Phone, City, Address FROM User";

        public static string CreateUser =>
            @"Inser Into User(FirstName, LastName, Gender, DocumentTypeId, DocumentCode, Phone, City, Address) Values(@FirstName, @LastName, @Gender, @DocumentTypeId, @DocumentCode, @Phone, @City, @Address)";

        public static string RemoveUser => "Remove From User Where Id = @Id";

        public static string UpdateUser =>
            @"Update Person 
                Set
                    FirstName = @FirstName,
                    LastName = @LastName,
                    Gender = @Gender,
                    DocumentTypeId = @DocumentTypeId,
                    DocumentCode = @DocumentCode, 
                    Phone = @Phone,
                    City = @City,
                    Address = @Address
                WHERE Id = @Id;";
    }
}
