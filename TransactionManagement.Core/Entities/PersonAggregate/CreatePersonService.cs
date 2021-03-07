using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Entities.PersonAggregate
{
    class CreatePersonService
    {
        Person _person;

        public CreatePersonService()
        {

        }

        public void CreateIncumbent(int id, string firstName, string lastName, char gender)
        {
            _person = new Incumbent(id, firstName, lastName, gender);
        }

        public void UpdateIncumbent(int id, string firstName, string lastName, char gender, string phone,
            string city, string address, int documentTypeId)
        {
            
        }
    }
}
