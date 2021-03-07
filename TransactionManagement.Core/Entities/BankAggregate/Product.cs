using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Entities.BankAggregate
{
    public class Product:BaseEntity<int>
    {
        public Product(int id): base(id)
        {

        }
    }
}
