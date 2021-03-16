using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Entities
{
    public class BaseEntity<Tkey>
    {
        public Tkey Id { get; protected set; }

        public BaseEntity()
        {

        }

        public BaseEntity(Tkey id)
        {
            Id = id;
        }
    }
}
