using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Entities.BankAggregate
{
    public class TransactionStatus : BaseEntity<int>
    {
        public TransactionStatus(int id, string status, string description) : base(id)
        {
            Status = status;
            Description = description;
        }

        public string Status { get; private set; }

        public string Description { get; private set; }
    }
}
