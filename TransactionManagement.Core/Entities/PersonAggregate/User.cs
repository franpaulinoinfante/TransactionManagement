using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Entities.PersonAggregate
{
    class User : Person
    {
        public User(int id, string firstName, string lastName, char gender) : base(id, firstName, lastName, gender)
        {

        }

        public string UserName { get; set; }

        public string Password { get; set; }

        public Byte[] Picture { get; set; }


    }
}
