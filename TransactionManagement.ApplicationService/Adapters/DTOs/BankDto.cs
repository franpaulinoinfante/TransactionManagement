using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.ApplicationService.Adapters.DTOs
{
    public class BankDto
    {
        public int Id { get; set; }
        public string BankName { get;  set; }
        public string Phone { get;  set; }
        public string City { get;  set; }
        public string Address { get; set; }
        public List<BankAccountDto> BankAccountDTOs { get; set; } = new List<BankAccountDto>();
    }
}
