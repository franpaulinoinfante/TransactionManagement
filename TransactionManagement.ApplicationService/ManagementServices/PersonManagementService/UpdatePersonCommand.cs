using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.ApplicationService.ManagementServices.PersonManagementService
{
    public class UpdatePersonCommand : ICommand
    {
        private readonly IPersonManagementService _personManagementService;
        private PersonDto _personDto;

        public UpdatePersonCommand(IPersonManagementService personManagement, PersonDto personDto)
        {
            _personManagementService = personManagement;
            _personDto = personDto;
        }

        public void Execute()
        {
            //_personManagementService.UpdatePerson(_personDto);
        }
    }
}
