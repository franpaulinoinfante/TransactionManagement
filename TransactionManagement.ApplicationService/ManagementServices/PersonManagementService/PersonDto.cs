using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService
{
    public class PersonDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public int? DocumentTypeId { get; set; }

        public string DocumentCode { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }

        public string Address { get; set; }
    }
}
