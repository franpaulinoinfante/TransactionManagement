using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Entities.BankAggregate
{
    public class ProductStatus:BaseEntity<int>
    {
        public ProductStatus(int id) : base(id)
        {

        }
    }
}
