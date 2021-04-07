using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.ApplicationService.ManagementServices.UserManagementServices
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentType { get; set; }
        public string Description { get; set; }
        public string DocumentCode { get; set; }
    }
}
