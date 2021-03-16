using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService
{
    public class CreatePersonCommand : ICommand
    {
        private readonly IPersonManagementService _personManagementService;
        private PersonDto _personDto;

        public CreatePersonCommand(IPersonManagementService personManagementService, PersonDto personDto)
        {
            _personManagementService = personManagementService;
            _personDto = personDto;
        }

        public void Execute()
        {
            //_personManagementService.CreatePerson(_personDto);
        }
    }
}
