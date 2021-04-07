using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Queries
{
    public static class PersonQueries
    {
        public static string GetPeople => 
            @"SELECT Id, FirstName, LastName, Gender, DocumentTypeId, DocumentCode, Phone, City, Address FROM Person";

        public static string CreatePerson =>
            @"INSERT INTO Person(FirstName, LastName, Gender, DocumentTypeId, DocumentCode, Phone, City, Address) VALUES(@FirstName, @LastName, @Gender, @DocumentTypeId, @DocumentCode, @Phone, @City, @Address);
                select last_insert_rowid();";

        public static string GetIncumbent => @"SELECT * FROM Incumbent";

        public static string UpdatePerson =>
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
        public static string RemovePerson => "";

        public static string GetPersonById => "";
    }
}
