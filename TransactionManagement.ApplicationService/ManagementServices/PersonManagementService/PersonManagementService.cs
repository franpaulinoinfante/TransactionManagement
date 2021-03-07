using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Entities.PersonAggregate;
using TransactionManagement.Core.Interfaces;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService
{
    public class PersonManagementService:IPersonManagementService
    {
        private IPersonRepositoy _personRepository;

        public PersonManagementService(IPersonRepositoy personRepository)
        {
            _personRepository = personRepository;
        }

        public void CreatePerson(int id, string firstName, string lastName, char gender)
        {
            Person incumbent = new Incumbent(id, firstName, lastName, gender);
        }

        public void UpdatePerson()
        {

        }
    }
}
