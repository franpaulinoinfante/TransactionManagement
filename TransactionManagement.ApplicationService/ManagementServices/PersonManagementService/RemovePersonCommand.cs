using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionManagement.Core.Interfaces;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService
{
    public class RemovePersonCommand : ICommand
    {
        private readonly IPersonRepository _personRespotiry;
        private PersonDto _personDto;

        public RemovePersonCommand(PersonDto personDto, IPersonRepository personRespotiry)
        {
            _personDto = personDto;
            _personRespotiry = personRespotiry;
        }

        public void Execute()
        {
            //_personManagementService.CreatePerson(_personDto);
        }
    }
}
